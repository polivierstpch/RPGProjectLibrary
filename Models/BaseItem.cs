using System.Collections.Generic;
using static RPGProjectLibrary.Helpers.PrintHelper;

namespace RPGProjectLibrary.Models
{
    public abstract class BaseItem
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public HashSet<ItemProperty> Properties { get; set; }
        public int GoldValue { get; set; }

        public virtual string ToJsonString()
        {
            return $"{{\"id\":{Id}," +
                   $"\"name\":\"{Name}\"," +
                   $"\"description\":\"{Description}\"," +
                   $"\"properties\":{PrintItemProperties(Properties)}," +
                   $"\"goldValue\":{GoldValue}";
        }
    }
}
