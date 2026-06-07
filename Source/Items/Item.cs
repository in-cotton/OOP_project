using System;
using System.Drawing; 

namespace OOP_project.Source.Items
{
    // 아이템 타입 지정 (Enum)
    public enum ItemType
    {
        Shuffle,
        Hint,
        Joker
    }


    // Item 클래스
    public abstract class Item
    {
        // 멤버 변수 
        protected string _itemId;
        protected string _name;
        protected int _remainingUses;

        // 속성 
        public string ItemId => _itemId;
        public string Name => _name;
        public int RemainingUses => _remainingUses;

        // 생성자 
        public Item(string itemId, string name, int uses)
        {
            _itemId = itemId;
            _name = name;
            _remainingUses = uses;
        }

        // 추상 메서드 
        public abstract bool Execute(Board board);
        public abstract ItemType GetItemType();

        // 가상 메서드 
        public virtual bool IsAvailable()
        {
            return _remainingUses > 0;
        }

        public virtual void OnUsed()
        {
            DecrementUses();
            // 여기에 효과음 재생 로직 등 추가 가능 
        }

        // 일반 메서드
        public void DecrementUses()
        {
            if (_remainingUses > 0)
            {
                _remainingUses--;
            }
        }
    }
}