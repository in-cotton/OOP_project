using System;
using OOP_project.Source.Models;

namespace OOP_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 사과 게임 정식 API 스펙 기능 테스트 ===");

            // 1. 6행 8열 규격의 보드판 객체 모델 생성 (내부적으로 CreateBoard 자동 호출)
            Board board = new Board(6, 8);

            // 2. 사과 무작위 배치 및 데이터 매칭
            board.GenerateApples();
            board.DisplayBoardConsole();

            // 3. 특정 좌표 선택 및 사과 제거 기능 테스트 (API 매칭 검증)
            Position testPos = new Position(2, 3); // X=2, Y=3 칸 타겟
            Cell targetCell = board.GetCell(testPos);

            if (targetCell != null && targetCell.HasApple())
            {
                Console.WriteLine($"\n[이벤트] 좌표 ({testPos.x}, {testPos.y})의 셀을 드래그 선택 후 사과를 제거합니다.");
                targetCell.Select();       // 셀 선택 상태 전환 테스트
                targetCell.RemoveApple();   // 사과 데이터 삭제 테스트
            }

            // 결과 확인을 위해 다시 출력 (해당 칸이 '.'으로 변함)
            board.DisplayBoardConsole();

            // 4. 리필 기능 테스트
            Console.WriteLine("\n[이벤트] 빈 칸에 새로운 사과를 다시 채워 넣습니다 (RefillEmptyCells)");
            board.RefillEmptyCells();
            board.DisplayBoardConsole();
        }
    }
}
