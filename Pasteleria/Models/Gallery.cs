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

        public int Image_ID { get; set; } = new();
        [ForeignKey("Image_ID")]
        public Images Images { get; set; } = new();

    }

    public class Card_Gallery : Component{ 
        public string Title { get; set; }
        public int Carousel { get; set; }
        public int CardByRow { get; set; }


        [NotMapped]
        public List<Item_Gallery> Items { get; set; } = new();


    }

    public class Item_Gallery : Component {
        public string Title { get; set; }
        public string InnerTitle { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ButtonText { get; set; }
        public string ButtonIcon { get; set; }
        public string ButtonUrl { get; set; }


        [NotMapped]
        public Images Image { get; set; } = new();

    }

    public class Images : Component
    {
        public string Url { get; set; }
    }

}
