using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Pasteleria.Models
{
    public class Resources
    {
        //Index

        public static string appName = "Pasteleria";
        public static string appVersion = "v21.09.01";

        public static List<Menu> menu = new List<Menu>() {
            new Menu(){ name = "HOME", url = "Index", title1 =  "DoÑA JENY", title2 = "Pasteles y Postres"},
            new Menu(){ name = "SHOP", url = "Shop", title1 = "Shop" },
            new Menu(){ name = "PRODUCTS", url = "Products", title1 = "Product Name" },
            
        };

    }


    public class Menu { 
    
        public string name { get; set; }
        public string url { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }

    } 
}
