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

        public void ResourcePastelesCatalogo001() {

            //1
            Gallery.Add(new Models.Gallery
            {
                Card_Gallery = new Card_Gallery
                {
                    IDCatalogo = 1,
                    Title = "TORTAS DE CHOCOLATE",
                    CardByRow = 2,
                    Carousel = 1,

                    Items = new List<Item_Gallery>{
                        new Item_Gallery{
                            Title = "Torta001",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel001", Url = "http://drive.google.com/uc?export=view&id=1g06qHbi_EWCmQEwjo6yta0Ayo3QpecVH" }
                        },
                        new Item_Gallery{
                            Title = "Torta002",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel002", Url = "http://drive.google.com/uc?export=view&id=1cy_ur0aMmp8m4nWPpWdtGG-6hAoUkq8j" }
                        },
                        new Item_Gallery{
                            Title = "Torta003",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel003", Url = "http://drive.google.com/uc?export=view&id=17ePPd7Pc8w_rV51tfIz9M49vocZqSe3E" }
                        },
                        new Item_Gallery{
                            Title = "Torta004",
                            InnerTitle = "",
                            Description = "",
                            Image = new Images{ Description = "Pastel004", Url = "http://drive.google.com/uc?export=view&id=1QrEhurjWuxwSrDQ7o_-ySJ0AYqrwu7XR" }
                        }
                   }
                }
            });

        }


    }
    
}
