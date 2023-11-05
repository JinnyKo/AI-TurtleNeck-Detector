import csv
from ultralytics.engine.results import Results
from ultralytics.models.yolo.detect.predict import DetectionPredictor
from ultralytics.utils import DEFAULT_CFG, LOGGER, ROOT, ops
from ultralytics import YOLO
from PIL import Image
import math
import os

class PosePredictor(DetectionPredictor):

    def __init__(self, cfg=DEFAULT_CFG, overrides=None, _callbacks=None):
        self.args.task = 'pose'
        if isinstance(self.args.device, str) and self.args.device.lower() == 'mps':
            LOGGER.warning("WARNING ⚠️ Apple MPS known Pose bug. Recommend 'device=cpu' for Pose models. "
                           'See https://github.com/ultralytics/ultralytics/issues/4031.')

    def postprocess(self, preds, img, orig_imgs):
        """Return detection results for a given input image or list of images."""
        preds = ops.non_max_suppression(preds,
                                        self.args.conf,
                                        self.args.iou,
                                        agnostic=self.args.agnostic_nms,
                                        max_det=self.args.max_det,
                                        classes=self.args.classes,
                                        nc=len(self.model.names))

        results = []
        for i, pred in enumerate(preds):
            orig_img = orig_imgs[i] if isinstance(orig_imgs, list) else orig_imgs
            shape = orig_img.shape
            pred[:, :4] = ops.scale_boxes(img.shape[2:], pred[:, :4], shape).round()
            pred_kpts = pred[:, 6:].view(len(pred), *self.model.kpt_shape) if len(pred) else pred[:, 6:]
            pred_kpts = ops.scale_coords(img.shape[2:], pred_kpts, shape)
            path = self.batch[0]
            img_path = path[i] if isinstance(path, list) else path
            results.append(
                Results(orig_img=orig_img,
                        path=img_path,
                        names=self.model.names,
                        boxes=pred[:, :6],
                        keypoints=pred_kpts))
        return results
def predict_and_save(image_folder, model_path,result_path):

    model = YOLO(model_path)
    results = model(image_folder)
    for i, r in enumerate(results):
        im_array = r.plot()
        im = Image.fromarray(im_array[..., ::-1])

        original_image_name = os.path.basename(r.path)  # 원본 이미지 파일 이름
        detected_image_name = f"{os.path.splitext(original_image_name)[0]}_detected.jpg"  # 원본 이미지 이름 + _detected.jpg
        file_path = os.path.join(result_path, detected_image_name)
        im.save(file_path)  # 이미지 저장

    keypoints_xyn = results[0].keypoints.xyn

    data = []
    for kp in keypoints_xyn:
        data.append(kp)

    # CSV 파일 생성 및 데이터 저장
    csv_filename = "result_points.csv"
    csv_path = os.path.join(result_path, csv_filename)

    with open(csv_path, mode='w', newline='') as file:
        writer = csv.writer(file)
        # 데이터 추가
        writer.writerows(data)

if __name__ == "__main__":
 c# 에서 받아서 경로 적용하기
    if len(sys.argv) != 6:
        raise ValueError("This script expects 5 arguments: model_path, GoodPose_image_path, GoodPose_keypoints_path, UserPose_image_path, UserPose_keypoints_path")
    model_path = sys.argv[1]
    GoodPose_image_path = sys.argv[2]
    GoodPose_keypoints_path = sys.argv[3]
    UserPose_image_path = sys.argv[4]
    UserPose_keypoints_path = sys.argv[5]

    if not os.path.exists(GoodPose_keypoints_path + "/result_points.csv "):
        predict_and_save(GoodPose_image_path, model_path, GoodPose_keypoints_path)
        predict_and_save(UserPose_image_path, model_path, UserPose_keypoints_path)
    else:
        predict_and_save(UserPose_image_path, model_path, UserPose_keypoints_path)

