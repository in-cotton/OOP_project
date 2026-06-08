# 2026년도 1학기 객체지향프로그래밍 팀 프로젝트 - 사과 게임

# --------------------------------------------------
< 프로젝트 디렉토리 구조>

 OOP_project/
 │
 ├── .vscode/                            # VS Code 실행 및 빌드 설정
 ├── OOP_project.csproj                  # 프로젝트 설정 파일
 │
 ├── Assets/                             # 이미지, 사운드 등 리소스 폴더
 │  ├── Images/                         # 사과 이미지, 아이템 아이콘 등
 │  └── Sounds/                         # 효과음, 배경음악
 │
 ├── Program.cs                          # 게임 진입점 (Main)
 │
 └── Source/                             # 실제 게임 소스 코드 폴더
     │
     ├── Interfaces/                     # 인터페이스 모음
     │   ├── IDisplayable.cs            # 화면에 그려질 수 있는 객체의 규격
     │   ├── IRankingService.cs         # 랭킹 저장/로드 시스템의 규격
     │   └── IUsable.cs                 # 아이템처럼 사용 처리가 가능한 객체의 규격
     │
     ├── Logic/                          # 게임 핵심 라이프사이클 및 매니저 (규칙 및 수학적 연산)
     │   ├── GameManager.cs
     │   ├── GameData.cs
     │   ├── Combo.cs
     │   └── GameLogic.cs 
     │
     ├── Models/                         # 사과 및 보드 데이터 객체
     │   ├── Apple.cs		            (NormalApple, JokerApple 포함)          
     │   ├── Cell.cs          
     │   └── Position.cs                (좌표 구조체) 
     │
     ├── Items/                          # 아이템 시스템 
     │   ├── Item.cs           
     │   ├── ItemInventory.cs  
     │   ├── ShuffleItem.cs   
     │   ├── HintItem.cs   
     │   └── JokerItem.cs  
     │
     ├── Ranking/                        # 로컬 랭킹 시스템 
     │   ├── RankingManager.cs          # IRankingService를 상속받아 실제 구현하는 클래스
     │   └── RankingEntry.cs   
     │
     └── UI/                             # 윈도우 폼 화면 및 비주얼 (View)
         ├── MainMenuForm.cs   
         ├── GameForm.cs       
         └── Components/       
             └── AppleButton.cs          # IDisplayable을 구현할 커스텀 버튼

