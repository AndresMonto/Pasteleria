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

        public static string appName = "AMR-PASTELERIA";
        public static string appVersion = "v21.09.01";

        public string HOME = "Home";
        public string HOMEurl = "Index";
        public string SHOP = "Shop";
        public string PRODUCTS = "Products";
        public string COMMENT = "Coment";

        public List<Menu> menu = new();
        public List<Card_Gallery> gallery = new();

        public Resource() {

            //Menus

            menu = (new List<Menu>() {
                new Menu(){ name = HOME, url = HOMEurl, title1 =  "PUNTO DULCE MAY", title2 = "El sabor no se improvisa" , order = 1},
                new Menu(){ name = SHOP, url = SHOP, title1 = "Shop", order = 2 },
                new Menu(){ name = PRODUCTS, url = PRODUCTS, title1 = "Product Name", order = 3 },
                new Menu(){ name = COMMENT, url = COMMENT, title1 = "Comentarios", order = 4 }

            }).OrderBy(x=> x.order).ToList();

            //Gallery

            gallery = (new List<Card_Gallery> {
                new Card_Gallery(){
                    title = "PASTELES",
                    module = HOME,
                    order = 1,
                    cardByRow = 3,

                    items = new List<Item_Gallery>(){
                        new Item_Gallery(){
                            title = "Pastel Chocolate",
                            titleUrl = "#",
                            innerTitle = "Descripción",
                            description = "Esto es una prueba del componente",
                            image = "http://drive.google.com/uc?export=view&id=1hLPgOsgKk0ClLcAm5Pbo-lTm5gfD3OM0",
                            price = 5500,
                            buttons = new List<Button_Gallery>(){ 
                                new Button_Gallery(){ 
                                    icon = "fa fa-shopping-cart",
                                    text = "Purchace",
                                    url = "#"
                                },
                                new Button_Gallery(){
                                    icon = "fa fa-link",
                                    text = "Details",
                                    url = "#"
                                }
                            }
                        },
                        new Item_Gallery(){
                            title = "Pastel Vainilla",
                            titleUrl = "#",
                            innerTitle = "Descripción",
                            description = "Esto es una prueba del componente",
                            image = "http://drive.google.com/uc?export=view&id=1RuR56RLyIg3IGyTqz7RKR13se7RG1BBC",
                            price = 6500,
                            buttons = new List<Button_Gallery>(){
                                new Button_Gallery(){
                                    icon = "fa fa-shopping-cart",
                                    text = "Purchace",
                                    url = "#"
                                },
                                new Button_Gallery(){
                                    icon = "fa fa-link",
                                    text = "Details",
                                    url = "#"
                                }
                            }
                        },
                        new Item_Gallery(){
                            title = "Pastel Vainilla",
                            titleUrl = "#",
                            innerTitle = "Descripción",
                            description = "Esto es una prueba del componente",
                            image = "http://drive.google.com/uc?export=view&id=1LV4tDtc7aheYeW4elR281L60FZVpGnlw",
                            price = 6500,
                            buttons = new List<Button_Gallery>(){
                                new Button_Gallery(){
                                    icon = "fa fa-shopping-cart",
                                    text = "Purchace",
                                    url = "#"
                                },
                                new Button_Gallery(){
                                    icon = "fa fa-link",
                                    text = "Details",
                                    url = "#"
                                }
                            }
                        },
                        new Item_Gallery(){
                            title = "Pastel Vainilla",
                            titleUrl = "#",
                            innerTitle = "Descripción",
                            description = "Esto es una prueba del componente",
                            image = "http://drive.google.com/uc?export=view&id=1PE4aMjFhMzHedEccAjwBOcVkHFL1kuPZ",
                            price = 6500,
                            buttons = new List<Button_Gallery>(){
                                new Button_Gallery(){
                                    icon = "fa fa-shopping-cart",
                                    text = "Purchace",
                                    url = "#"
                                },
                                new Button_Gallery(){
                                    icon = "fa fa-link",
                                    text = "Details",
                                    url = "#"
                                }
                            }
                        }


                    }
                    
                },



            }).OrderBy(x => new{ x.module, x.order}).ToList();

        }        

    }


    public class Menu { 
    
        public string name { get; set; }
        public string url { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public int order { get; set; }

    }
}
