using System;

namespace OOP_project.Source.Models
{
    /// <summary>
    /// 게임 보드를 구성하고 셀 생성, 사과 배치 및 보드 상태를 관리하는 클래스입니다.
    /// </summary>
    public class Board
    {
        public int rows;           // 보드의 행(Row) 개수
        public int cols;           // 보드의 열(Column) 개수
        public Cell[,] cells;      // 보드를 구성하는 셀들을 저장하는 2차원 배열
        public Random random;      // 랜덤한 사과 생성에 사용되는 객체

        // 생성자 (명세서 규격을 안전하게 실행하기 위해 기본 초기화 포함)
        public Board(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.random = new Random();
            CreateBoard();
        }

        /// <summary>
        /// 보드와 셀을 생성하고 초기화하는 메서드입니다.
        /// </summary>
        public bool CreateBoard()
        {
            cells = new Cell[rows, cols];
            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // 고유 좌표 구조체를 넘겨주며 모든 칸의 Cell 객체 생성
                    Position pos = new Position(c, r); // x=열(c), y=행(r)
                    cells[r, c] = new Cell(pos);
                }
            }
            return true;
        }

        /// <summary>
        /// 보드에 일반 사과와 조커 사과를 생성하여 배치하는 메서드입니다.
        /// </summary>
        public void GenerateApples()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // 예시 확률 규칙: 7% 확률로 조커 사과 생성, 93% 확률로 일반 사과 생성
                    if (random.Next(0, 100) < 7)
                    {
                        cells[r, c].apple = new JokerApple();
                    }
                    else
                    {
                        int randomValue = random.Next(1, 10); // 1~9 사이의 사과 숫자
                        cells[r, c].apple = new NormalApple(randomValue);
                    }
                }
            }
        }

        /// <summary>
        /// 비어 있는 셀에 새로운 사과를 생성하여 채우는 메서드입니다.
        /// </summary>
        public void RefillEmptyCells()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // 사과가 터져서 비어있는 칸이 있다면 새 일반 사과 동적 리필
                    if (!cells[r, c].HasApple())
                    {
                        int randomValue = random.Next(1, 10);
                        cells[r, c].apple = new NormalApple(randomValue);
                    }
                }
            }
        }

        /// <summary>
        /// 지정된 좌표의 셀 객체를 반환하는 메서드입니다. (인덱스 초과 예외 방지 포함)
        /// </summary>
        public Cell GetCell(Position position)
        {
            if (position.y >= 0 && position.y < rows && position.x >= 0 && position.x < cols)
            {
                return cells[position.y, position.x];
            }
            return null; // 범위를 벗어난 좌표 요청 시 안전하게 null 반환
        }

        /// <summary>
        /// 보드의 모든 셀 정보를 초기화하는 메서드입니다.
        /// </summary>
        public void ClearBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    cells[r, c].RemoveApple();
                    cells[r, c].Deselect();
                }
            }
        }

        /// <summary>
        /// [임시 메서드] 현재 백엔드 사과판 상태를 콘솔에 가시적으로 찍어주는 시뮬레이터
        /// </summary>
        public void DisplayBoardConsole()
        {
            Console.WriteLine($"\n[실시간 보드판 텍스트 뷰] 상태 (행:{rows} x 열:{cols})");
            Console.WriteLine(new string('=', cols * 5));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Cell cell = cells[r, c];
                    if (!cell.HasApple())
                    {
                        Console.Write("  .  "); // 사과가 터진 빈자리
                    }
                    else if (cell.apple.IsJoker)
                    {
                        Console.Write(" [J] "); // 조커 사과 표시
                    }
                    else
                    {
                        Console.Write($"  {cell.apple.Value}  "); // 일반 사과 수치
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('=', cols * 5));
        }
    }
}
