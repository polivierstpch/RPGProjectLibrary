using System.Collections.Generic;
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
            for (int i = 0; i < itemCollection.Length; i++)
            {
                sb.Append(itemCollection[i]);
                if(itemCollection[i] != itemCollection[itemCollection.Length - 1])
                    sb.Append(',');
            }   
            sb.Append(']');
            
            return sb.ToString();
        }
    }
}