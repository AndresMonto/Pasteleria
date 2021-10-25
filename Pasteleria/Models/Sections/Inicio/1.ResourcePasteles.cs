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

        public void ResourcePastelesInicio001() {

            
            //1
            Gallery.Add(new Models.Gallery{ 
                Card_Gallery = new Card_Gallery
                {
                   IDInicio = 1,
                   Title = "TORTAS",
                   CardByRow = 2,
                   Carousel = 0,

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
                        }
                   }
                }
            });

        }

    }
    
}
