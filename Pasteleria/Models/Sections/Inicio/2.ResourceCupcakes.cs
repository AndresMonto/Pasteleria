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
        public void ResourceCupcakesInicio002()
        {


            //2
            Gallery.Add(new Models.Gallery
            {
                Card_Gallery = new Card_Gallery
                {
                    IDInicio = 2,
                    Title = "CUPCAKES",
                    CardByRow = 2,
                    Carousel = 0,

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
                        }
                   }
                }
            });



        }

    }
    
}
