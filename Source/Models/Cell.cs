namespace OOP_project.Source.Models
{
    /// <summary>
    /// 보드의 한 칸을 나타내며 좌표, 사과 정보 및 선택 상태를 관리하는 클래스입니다.
    /// </summary>
    public class Cell
    {
        public Position position;   // 셀의 고유한 X, Y 좌표 정보
        public Apple apple;         // 현재 셀에 배치된 사과 객체
        public bool isSelected;     // 현재 셀이 선택되었는지 여부

        /// <summary>
        /// 생성자입니다. 생성 시점에 고유 좌표를 받아 저장 및 초기화합니다.
        /// </summary>
        public Cell(Position position)
        {
            this.position = position;
            this.apple = null;       // 초기에는 사과가 없음
            this.isSelected = false; // 초기에는 선택되지 않은 상태
        }

        /// <summary>
        /// 현재 셀에 사과가 존재하는지 확인합니다.
        /// </summary>
        public bool HasApple()
        {
            return apple != null;
        }

        /// <summary>
        /// 셀에 존재하는 사과를 제거합니다.
        /// </summary>
        public bool RemoveApple()
        {
            if (HasApple())
            {
                apple = null;
                return true; // 제거 성공
            }
            return false; // 제거할 사과가 없었음
        }

        /// <summary>
        /// 현재 셀을 선택 상태로 변경합니다.
        /// </summary>
        public bool Select()
        {
            isSelected = true;
            return true;
        }

        /// <summary>
        /// 현재 셀의 선택 상태를 해제합니다.
        /// </summary>
        public void Deselect()
        {
            isSelected = false;
        }

        /// <summary>
        /// 현재 셀의 좌표 구조체를 반환합니다.
        /// </summary>
        public Position GetPosition()
        {
            return position;
        }
    }
}
