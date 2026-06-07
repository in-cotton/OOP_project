using System;

namespace OOP_project.Source.Items
{
    public abstract class SingleUseItem : Item
    {
        // 멤버 변수
        protected bool _hasBeenUsed;

        // 속성
        public bool HasBeenUsed => _hasBeenUsed;

        // 생성자
        public SingleUseItem(string id, string name) : base(id, name, 1)
        {
            _hasBeenUsed = false;
        }

        // 아이템이 사용 가능한지 확인하는 오버라이드 메서드
        public override bool IsAvailable()
        {
            // 부모의 조건(남은 횟수 > 0)을 만족하고, 동시에 아직 사용한 적이 없어야(false) 함
            return base.IsAvailable() && !_hasBeenUsed;
        }

        // 아이템 성공적 발동 시 후처리 오버라이드 메서드
        public override void OnUsed()
        {
            _hasBeenUsed = true;   // 사용 완료 상태로 변경
            base.OnUsed();         // 부모의 로직(사용 횟수 1 차감) 실행
        }
    }
}