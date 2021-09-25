using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Pasteleria.Models
{
    public class Gallery : Component {

        public int Card_Gallery_ID { get; set; }
        [ForeignKey("Card_Gallery_ID")]
        public Card_Gallery Card_Gallery { get; set; } = new();

        public int Item_Gallery_ID { get; set; } = new();
        [ForeignKey("Item_Gallery_ID")]
        public Item_Gallery Item_Gallery { get; set; } = new();

    }

    public class Card_Gallery : Component{ 
        public string Title { get; set; }
        public short Carousel { get; set; }
        public int CardByRow { get; set; }


        [NotMapped]
        public List<Item_Gallery> Items { get; set; } = new();

    }

    public class Item_Gallery : Component {
        public int Order { get; set; }
        public string Title { get; set; }
        public string InnerTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public string ButtonText { get; set; }
        public string ButtonIcon { get; set; }
        public string ButtonUrl { get; set; }

    }

}
