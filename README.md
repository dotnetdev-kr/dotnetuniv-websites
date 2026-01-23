# .NET Universe 🌌

**.NET Universe** 공식 웹사이트 저장소입니다.

> 🔗 **라이브 사이트**: [https://dotnetuniverse.net/](https://dotnetuniverse.net/)
>
> 최신 행사 정보, 스터디, 컨퍼런스 일정 등은 라이브 웹사이트에서 확인하세요.

## 🛠️ 기술 스택

- **.NET 10** (ASP.NET Core Razor Pages)
- **Docker** 지원
- **Bootstrap** (UI 프레임워크)

## 🚀 개발 환경 설정

### 필수 요구사항

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- (선택) [Docker](https://www.docker.com/)

### 로컬 실행

```bash
# 저장소 클론
git clone https://github.com/dotnetdev-kr/dotnetuniv-websites.git
cd dotnetuniv-websites

# 프로젝트 실행
dotnet run --project DotNetUniverse
```

브라우저에서 `https://localhost:5001` 또는 `http://localhost:5000`으로 접속합니다.

### Docker 실행

```bash
# Docker Compose 사용
docker-compose up --build

# 또는 직접 빌드 및 실행
docker build -t dotnetuniverse .
docker run -p 8080:80 dotnetuniverse
```

### 프로젝트 구조

```
DotNetUniverse/
├── Models/              # 도메인 모델
├── Pages/               # Razor Pages
├── Services/            # 서비스 계층 (행사/스터디 데이터)
├── wwwroot/             # 정적 파일 (CSS, JS, 이미지)
└── Program.cs           # 애플리케이션 진입점
```

## 📄 라이선스

이 프로젝트는 MIT 라이선스를 따릅니다.

## 🏗️ 아키텍처

이 프로젝트는 다음과 같은 아키텍처 패턴을 사용합니다:

- **Razor Pages**: 페이지 기반 웹 애플리케이션
- **서비스 계층**: `YearDataService`를 통한 행사 데이터 관리
- **동적 라우팅**: URL 슬러그 기반 행사 페이지 라우팅
- **불변 모델**: `record` 타입을 활용한 불변 데이터 모델

## 📜 라이선스

이 프로젝트는 오픈소스로 공개되어 있습니다.

## 🤝 기여하기

기여를 환영합니다! Pull Request나 Issue를 통해 참여해 주세요.

---

<p align="center">
  <strong>.NET Universe</strong> - AI 시대를 선도하는 국내 최대 .NET 개발자 컨퍼런스
</p>