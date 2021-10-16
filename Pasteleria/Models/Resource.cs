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
        //Home

        public static string appName = "AMR-PASTELERIA";
        public static string appVersion = "v21.10.31";

        public int ComponentInicioId = -1;
        public int ComponentCatalogoId = -1;

        public string HOME = "Home";
        public string HOMEurl = "Index";
        public string CATALOGUE = "Catalogues";
        public string PRODUCTS = "Products";
        public string COMMENT = "Comments";

        public List<Menu> Menu = new();
        public List<Gallery> Gallery = new();

        public Resource() {

            //var contex = new Context();

            //*** Menu ***//
            //Menu = contex.Menu.OrderBy(x=>x.Order).Where(x=> x.Active == 1).ToList();

            Menu = new List<Menu> {
                new Menu{
                    Name = "Inicio", Url= "Index", Title1 = "PUNTO DULCE MAY", Title2 = "El sabor no se improvisa", Active = 1
                },new Menu{
                    Name = "Catálogos", Url= "Catalogues", Title1 = "Catálogos", Title2 = "", Active = 1
                },new Menu{
                    Name = "Productos", Url= "Products", Title1 = "Productos", Title2 = "", Active = 0
                },new Menu{
                    Name = "Comentarios", Url= "Comments", Title1 = "Comentarios", Title2 = "", Active = 0
                },
            };


            ////*** Gallery ***//
             
            ResourcePastelesInicio001();
            ResourceCupcakesInicio002();

            ResourcePastelesCatalogo001();
            ResourcePastelesCatalogo002();
            ResourceCupcakesCatalogo003();


            ////*** Gallery ***//
            //var queryGallery = contex.Gallery.AsQueryable();
            //queryGallery = queryGallery.Include(x=> x.Card_Gallery).Include(x=>x.Item_Gallery).Include(x=>x.Images);

            //var listQuery = queryGallery.ToList();

            ////Distinto Id de Card
            //var distinctCard = listQuery.Select(x=>x.Card_Gallery.ID).Distinct();

            ////Agrega a Gallery el Card
            //foreach (var cardId in distinctCard)
            //{
            //    Gallery.Add(new Gallery() { 
            //        Card_Gallery = listQuery.Select(x=>x.Card_Gallery).First(x => x.ID == cardId)
            //    });
            //}

            ////Agrega Items al Card
            //foreach (var card_gallery in Gallery.Select(x=>x.Card_Gallery))
            //{
            //    foreach (var item_gallery in listQuery.Where(x => x.Card_Gallery_ID == card_gallery.ID).Select(x => x.Item_Gallery))
            //    {
            //        item_gallery.Image = listQuery.Where(x => x.Card_Gallery_ID == card_gallery.ID && x.Item_Gallery_ID == item_gallery.ID).Select(x=>x.Images).First();
            //        Gallery.First(x=>x.Card_Gallery.ID == card_gallery.ID).Card_Gallery.Items.Add(item_gallery);
            //    }
            //}

        }        

    }
    
}
