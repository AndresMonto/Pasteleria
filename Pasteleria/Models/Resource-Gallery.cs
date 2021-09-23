using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Pasteleria.Models
{
    public class Card_Gallery { 
    
        public string title { get; set; }
        public List<Item_Gallery> items { get; set; } = new();
        public int order { get; set; }
        public string module { get; set; }
        public bool carousel { get; set; }
        public int cardByRow { get; set; }

    }

    public class Item_Gallery {

        public string title { get; set; }
        public string titleUrl { get; set; }
        public string innerTitle { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int price { get; set; }
        public List<Button_Gallery> buttons { get; set; } = new();
    }

    public class Button_Gallery {

        public string text { get; set; }
        public string icon { get; set; }
        public string url { get; set; }

    }
}
