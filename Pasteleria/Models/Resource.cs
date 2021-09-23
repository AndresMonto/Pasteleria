using Pasteleria.BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace Pasteleria.Models
{
    public partial class Resource
    {
        //Home

        public static string appName = "AMR-PASTELERIA";
        public static string appVersion = "v21.09.01";

        public string HOME = "Home";
        public string HOMEurl = "Index";
        public string CATALOGUE = "Catalogues";
        public string PRODUCTS = "Products";
        public string COMMENT = "Comments";

        public List<Menu> menu = new();
        public List<Card_Gallery> gallery = new();

        public Resource() {

            //Menus

            var contex = new Context();

            menu = contex.Menu.OrderBy(x=>x.Order).ToList();

            //Gallery

            gallery = (new List<Card_Gallery> {
                new Card_Gallery(){
                    title = "PASTELES",
                    module = HOME,
                    order = 1,
                    carousel = true,
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
                            image = "http://drive.google.com/uc?export=view&id=1t0bcgDyPOlRDXGR5J5EDl1NcZh4kvHGP",
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
                        },
                        new Item_Gallery(){
                            title = "Pastel Vainilla",
                            titleUrl = "#",
                            innerTitle = "Descripción",
                            description = "Esto es una prueba del componente",
                            image = "http://drive.google.com/uc?export=view&id=1y-cTE27MtvtQsSDasrgk10fTrODu6cFO",
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
                            image = "http://drive.google.com/uc?export=view&id=1YhuQF_xRWhUT_i-orXzXDj_pSdKRytSf",
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
    
}
