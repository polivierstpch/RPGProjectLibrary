using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGProjectLibrary.Models;

namespace RPGProjectLibrary.Helpers
{
    public static class PrintHelper
    {
        public static string PrintItemProperties(ICollection<ItemProperty> itemProperties)
        {
            var sb = new StringBuilder();

            sb.Append('[');
            int count = 0;
            foreach(var itemProperty in itemProperties)
            {
                count++;
                sb.Append($"\"{itemProperty.Name.ToLower()}\"");
                
                if (count != itemProperties.Count)
                    sb.Append(",");
            }
            sb.Append(']');

            return sb.ToString();
        }

        public static string PrintItemCollectionAsJson(params BaseItem[] itemCollection)
        {   
            var sb = new StringBuilder();
            sb.Append('[');
            foreach (var item in itemCollection)
            {
                sb.Append(item.ToJsonString());
                if (itemCollection.Last() != item)
                    sb.Append(',');
            }
            sb.Append(']');
            
            return sb.ToString();
        }
    }
}