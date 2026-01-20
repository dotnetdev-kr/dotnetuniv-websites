# .NET Universe 🌌

국내 최대 .NET 개발자 컨퍼런스 **.NET Universe** 공식 웹사이트입니다.

> 🔗 **GitHub**: [dotnetdev-kr/dotnetuniv-websites](https://github.com/dotnetdev-kr/dotnetuniv-websites)

## 📖 소개

.NET Universe는 2019년부터 시작된 국내 최대 .NET 개발자 컨퍼런스입니다. AI 시대를 선도하며 오픈소스와 함께 성장하는 개발자들의 축제로, 매년 다양한 주제의 세션과 워크샵을 제공합니다.

### 🏆 행사 실적

- **7년** 역사 (2019 ~ 현재)
- **2,000+** 누적 참가자
- **150+** 누적 세션
- **100+** 연사

## 🛠️ 기술 스택

- **.NET 10** (ASP.NET Core Razor Pages)
- **Docker** 지원
- **Bootstrap** (UI 프레임워크)

## 📁 프로젝트 구조

```
DotNetUniverse/
├── Models/                          # 도메인 모델
│   ├── Collections/                 # 컬렉션 클래스
│   │   ├── SessionCollection.cs
│   │   ├── SpeakerCollection.cs
│   │   ├── SponsorCollection.cs
│   │   ├── TrackCollection.cs
│   │   └── VenueCollection.cs
│   ├── EventInfo.cs                 # 행사 정보
│   ├── Session.cs                   # 세션 정보
│   ├── Speaker.cs                   # 연사 정보
│   ├── Sponsor.cs                   # 스폰서 정보
│   ├── Track.cs                     # 트랙 정보
│   ├── ScheduleGrid.cs              # 스케줄 그리드
│   └── ...
├── Pages/                           # Razor Pages
│   ├── Index.cshtml                 # 메인 페이지
│   ├── Archive.cshtml               # 아카이브 페이지
│   ├── About.cshtml                 # 소개 페이지
│   ├── Years/                       # 연도별 행사 페이지
│   │   └── Event.cshtml
│   └── Shared/
│       └── _Layout.cshtml           # 공통 레이아웃
├── Services/                        # 서비스 계층
│   ├── SessionDisplayService.cs     # 세션 표시 서비스
│   └── YearData/                    # 연도별 행사 데이터
│       ├── IYearData.cs             # 행사 데이터 인터페이스
│       ├── YearDataService.cs       # 행사 데이터 서비스
│       ├── Year2019Data.cs
│       ├── Year2021Data.cs
│       ├── Year2022Data.cs
│       ├── Year2023Data.cs
│       ├── Year2024Data.cs
│       └── Year2025Data.cs
└── Program.cs                       # 애플리케이션 진입점
```

## 🚀 시작하기

### 필수 요구사항

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### 로컬 실행

```bash
# 저장소 클론
git clone https://github.com/dotnetdev-kr/dotnetuniv-websites.git
cd dotnetuniv-websites

# 프로젝트 실행
dotnet run --project DotNetUniverse
```

### Docker 실행

```bash
# Docker 이미지 빌드
docker build -t dotnetuniverse .

# 컨테이너 실행
docker run -p 8080:80 dotnetuniverse
```

## 📅 행사 연혁

| 연도 | 행사명 | 규모 |
|------|--------|------|
| 2025 | .NET Universe 2025 | Conference |
| 2024 | .NET Universe 2024 | Conference |
| 2023 | .NET Universe 2023 | Conference |
| 2022 | .NET Universe 2022 | Conference |
| 2021 | .NET Universe 2021 | Conference |
| 2019 | .NET Universe 2019 | Conference |

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