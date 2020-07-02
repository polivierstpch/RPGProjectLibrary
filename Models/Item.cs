
namespace RPGProjectLibrary.Models
{
    public class Item : BaseItem
    {
        public override string ToJsonString()
        {
            return base.ToJsonString() +
                   "}}";
        }
    }
}