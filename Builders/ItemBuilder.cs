using RPGProjectLibrary.Models;

namespace RPGProjectLibrary.Builders
{
    public class ItemBuilder : BaseItemBuilder<Item, ItemBuilder>
    {
        protected override Item Build() => new Item
        {
            Name = Name,
            Description = Description,
            Properties = Properties,
            GoldValue = GoldValue
        };
        
    }
}