# AI-TurtleNeck-Detector
## AI 거북목 실시간 탐지 및 알림 소프트웨어 프로젝트 개요 
장시간 컴퓨터 사용을 하면서 나도 모르게 거북목 증후군 자세를 취하게 되는 경우가 많았습니다. 매번 스스로 인지하기 힘들기 때문에 거북목 자세를 실시간으로 알려주는 서비스를 개발하게 되었습니다. 
- Pose Estimation 기술을 활용하여 웹캠상의 사용자 이미지 좌표를 실시간으로 읽습니다.
- 자체 거북목 계산 알고리즘을 통해 일정 수준의, 일정 기간의 거북목으로 인식되면 메세지를 띄우는 응용 소프트웨어 입니다.
- 약 5000개의 상반식 데이터를 직접 수집/및 라벨링 하여 YOLOV8Pose 모델을 사용하여 학습 시켰으며, 최적의 성능의 모델을 만들기 위해 Image size, Optimizer, single_class 등의 하이파 파라미터들을 변경 해보며 최적의 성능의 모델을 만들었습니다. 
  
## 인터페이스 설계 
![image](https://github.com/JinnyKo/AI-TurtleNeck-Detector/assets/93627969/239c8564-e7ae-4d43-b866-41c6dcc49b39)

## 라벨링을 위한 KeyPoint 정의 
![image](https://github.com/JinnyKo/AI-TurtleNeck-Detector/assets/93627969/94dd0543-94c2-4ddf-a283-711d5b4e1e69

## 본 프로젝트에서 적용한 거북목 판별 방법 : "변화율" 판단 
![image](https://github.com/JinnyKo/AI-TurtleNeck-Detector/assets/93627969/b6b8adf7-a085-4d35-bc2e-dbbac2f129ad)

> **Challenge 1 **   
웹캠과 피사체의 거리, 피사체 별 신체적인 크기 는 전부 다르기 때문에, 이를 절대적인 변화량에 맞추어 거북목을 탐지하는 것엔 잦은 오류가 있었다. 따라서 어깨 좌표, 목 끝 점 좌표 등을 사용하여 바른 자세와 거북목 자세일 때의 일정 변화율을 사용하였다.  





