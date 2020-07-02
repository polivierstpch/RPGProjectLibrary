
namespace RPGProjectLibrary.Models
{
    public class Item : BaseItem
    {
        private static int _currentId;

        public Item() => Id = ++_currentId;

        public override string ToJsonString()
        {
            return base.ToJsonString() +
                   "}}";
        }
    }
}