using Pasteleria.BusinessLogic;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Security.Cryptography.X509Certificates;

namespace Pasteleria.Models
{
    public partial class Resource
    {
        public void ResourcePastelesCatalogo002()
        {

            ////*** Gallery ***//

            //2
            Gallery.Add(new Models.Gallery
            {
                Card_Gallery = new Card_Gallery
                {
                    IDCatalogo = 2,
                    Title = "PASTELES PERSONALIZADOS",
                    CardByRow = 2,
                    Carousel = 1,

                    Items = new List<Item_Gallery>{
                        new Item_Gallery{
                            Title = "Pastel005",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel005", Url = "http://drive.google.com/uc?export=view&id=1RGVlrV4mo0xLijHPYeUlTWpA5na0TN7l" }
                        },
                        new Item_Gallery{
                            Title = "Pastel006",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel006", Url = "http://drive.google.com/uc?export=view&id=1Qw4sbtHh2M-nm2rMSkflif5KiWSgkemr" }
                        },
                        new Item_Gallery{
                            Title = "Pastel007",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel007", Url = "http://drive.google.com/uc?export=view&id=1HeFo9FJ1XBIKCgkGmHoQiUvso6W5PJfQ" }
                        },
                        new Item_Gallery{
                            Title = "Pastel008",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel008", Url = "http://drive.google.com/uc?export=view&id=1IqRqIds0e0J2OnV2B-ef6t89ZmjGMcpJ" }
                        },
                        new Item_Gallery{
                            Title = "Pastel009",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel009", Url = "http://drive.google.com/uc?export=view&id=1etTbUERhlypNW6N1pp3dAOIlQ0DhyKPY" }
                        },
                        new Item_Gallery{
                            Title = "Pastel010",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel010", Url = "http://drive.google.com/uc?export=view&id=1kdwS389208ysjPsA7bu1w-za-FXaE3F3" }
                        }
                   }
                }
            });



        }

    }
    
}
