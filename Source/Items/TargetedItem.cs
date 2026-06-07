using System;

namespace OOP_project.Source.Items
{
    public abstract class TargetedItem : Item
    {
        // 멤버 변수
        protected Cell _targetCell;

        // 속성
        public Cell TargetCell => _targetCell;

        // 생성자
        public TargetedItem(string id, string name, int uses) : base(id, name, uses)
        {
            _targetCell = null; // 초기에는 선택된 타겟이 없음
        }

        // 타겟형 아이템이 실제로 수행할 일을 정의하는 추상 메서드
        public abstract bool Execute(Board board, Cell targetCell);

        // 부모(Item)의 단일 매개변수 Execute를 오버라이드 메서드
        public override bool Execute(Board board)
        {
            // 타겟 정보 없이 이 메서드가 호출되면 사용 불가 처리
            // "대상을 지정해야 합니다"라는 예외 방지용 안전장치 
            return false;
        }

        // 플레이어가 보드판의 특정 칸을 터치했을 때 타겟 주소를 저장하는 메서드
        public void SetTarget(Cell cell)
        {
            _targetCell = cell;
        }
    }
}