using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Pasteleria.Models
{
    public partial class Resource
    {
        //Home

        public static string appName = "PASTELERIA";
        public static string appVersion = "v21.09.01";

        public string HOME = "Home";
        public string HOMEurl = "Index";
        public string PRODUCTS = "Products";
        public string SHOP = "Shop";

        public List<Menu> menu = new List<Menu>();

        public Resource() {

            //Menus

            menu = new List<Menu>() {
                new Menu(){ name = HOME, url = HOMEurl, title1 =  "DOÑA JENY", title2 = "Pasteles y Postres"},
                new Menu(){ name = PRODUCTS, url = PRODUCTS, title1 = "Product Name" },
                new Menu(){ name = SHOP, url = SHOP, title1 = "Shop" }

            };
        }        

    }


    public class Menu { 
    
        public string name { get; set; }
        public string url { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }

    }
}
