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
        public void ResourceCupcakescatalogo002()
        {

            ////*** Gallery ***//

            //2
            Gallery.Add(new Models.Gallery
            {
                Card_Gallery = new Card_Gallery
                {
                    IDCatalogo = 2,
                    Title = "CUPCAKES",
                    CardByRow = 2,
                    Carousel = 1,

                    Items = new List<Item_Gallery>{
                        new Item_Gallery{
                            Title = "Cupcake001",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Cupcake001", Url = "http://drive.google.com/uc?export=view&id=1YDg1HdPZMdCq34wSZnOe0plxpR4bMPdq" }
                        },
                        new Item_Gallery{
                            Title = "Cupcake002",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Cupcake002", Url = "http://drive.google.com/uc?export=view&id=10OfSqU3Lc-fmsFf9Lmyl5uUVkFHDdxn5" }
                        },
                        new Item_Gallery{
                            Title = "Cupcake003",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Cupcake003", Url = "http://drive.google.com/uc?export=view&id=1leGivWlAGH3lV2_migKhQD9fNACopiS_" }
                        },
                        new Item_Gallery{
                            Title = "Cupcake004",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Cupcake004", Url = "http://drive.google.com/uc?export=view&id=1jYpWWdgMdoQIn880OLwwoFuyCUIvjfbL" }
                        },
                        new Item_Gallery{
                            Title = "Cupcake005",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Cupcake005", Url = "http://drive.google.com/uc?export=view&id=1IprzEfa6kgR1KTgfCnwa4KDynBE5MCIb" }
                        },
                        new Item_Gallery{
                            Title = "Cupcake006",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Cupcake006", Url = "http://drive.google.com/uc?export=view&id=11y1WocSr5vU_PVlvtJQ-ajKxA1XxwFQg" }
                        }
                   }
                }
            });



        }

    }
    
}
