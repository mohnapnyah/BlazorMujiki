using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMujiki.Data
{
    public class Item
    {
        public string ItemName { get; set; }
        public int ItemCount { get; set; }

        public Item(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }
    }
}
