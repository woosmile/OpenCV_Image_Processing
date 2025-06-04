# OpenCV Gaussian Filter 영상처리 프로그램

이 프로그램은 **.NET Framework 4.8** 및 **OpenCV(OpenCvSharp)** 를 기반으로 한 **C# WinForms 영상처리 프로그램** 입니다.  
사용자가 이미지를 불러오고, Gaussian 커널 사이즈를 조절하여 필터를 적용할 수 있습니다.

## 🖼️ UI 구성



### 기본 동작
- Open Image: 필터를 적용할 이미지 파일 불러오기 (불러온 이미지 좌측에 출력)
- size X: Gaussian 필터 커널 X 크기 지정 (홀수값)
- size Y: Gaussian 필터 커널 Y 크기 지정 (홀수값)
- Gaussian Filter: 필터 적용 (적용 후 이미지 우측에 출력)
- Save Image: 필터가 적용된 이미지 저장 (저장 파일명에 gaussian_ 추가)
- Prev/Next: 불러온 이미지 탐색

### Sequence (검사 장비 모방)
- Camera Open: 카메라 Open Flag 변수 True로 지정
- Grab Start: 필터를 적용할 이미지 파일을 불러온 후 1초 간격으로 불러온 이미지를 좌측에 순서대로 출력
- Filter Start: 현재 이미지에 필터를 적용해서 우측에 출력 및 저장
- Filter Stop: 필터 적용 비활성화
- Grab Stop: 좌측에 이미지 출력 중지
- Camera Close: 카메라 Open Flag False로 지정

## 🧩 주요 기능

- Gaussian 커널 크기를 지정하여 필터 적용 전/후 이미지 확인
- 필터 처리 시간(ms) 표시
- 이미지 탐색 (Next/Prev 버튼)
- Sequence를 통해 불러온 이미지를 1초 간격으로 필터 적용 및 자동 저장

## 🛠️ 개발 환경

- **언어**: C#
- **프레임워크**: .NET Framework 4.8
- **GUI**: Windows Forms
- **라이브러리**: [OpenCvSharp4.Windows](https://www.nuget.org/packages/OpenCvSharp4.Windows/) (NuGet)

## ⚙️ 설치 및 실행 방법

### 1. 사전 요구 사항

- Windows 10 이상
- Visual Studio 2019 이상
- .NET Framework 4.8 Developer Pack 설치

### 2. 실행 절차

```bash
# 저장소 클론
git clone https://github.com/woosmile/OpenCV_Image_Processing.git

# Visual Studio로 솔루션 열기
# NuGet 패키지 복원 후 빌드
