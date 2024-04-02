using KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft.Controllers
{
    public class MyWorkController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<Products>
            {
            
            
            new Products {Id = 1,Name="Suzy Lee", Country="Made in China", Description="Chinese hand-crafted pottery.",Price=150,ImgUrl="images/pottery.jpg"},
            new Products {Id = 2, Name ="Max Gomez",Country="Made in Mexico", Description = "Traditional Mexican vase.", Price = 250, ImgUrl = "images/MexicanPottery.jpg" },
            new Products { Id = 3,Name="Toby Loberg", Country="Made in Greece", Description="Greece hand-craft vase.",Price=150,ImgUrl="images/GreecePottery.jpg"},

           
            new Products {Id = 4, Name ="Shanti Singh", Country="Made in India", Description = "Indian sari emboridery.", Price = 550, ImgUrl = "images/indianHandCraft.jpg" },
            new Products {Id = 5, Name ="Tao Suzoki ", Country="Made in Japan", Description = "Japanse bonzai tree embroidery.", Price = 120, ImgUrl = "images/japanEmbroidery.jpg" },
            new Products {Id = 6, Name ="Reah Khan ", Country="Made in Pakistan", Description = "Pakistan scarf emboridery.", Price = 80, ImgUrl = "images/pakistanEmbroidery.jpg" },

            
            new Products {Id = 7, Name ="James Wilson ", Country="Made in America", Description = "Native American hand-craft Basket weaving.", Price = 250, ImgUrl = "images/basket.jpg" },
            new Products {Id = 8, Name ="Florence Nkosi ", Country="Made in Ghana", Description = "Ghana traditional woven basket.", Price = 300, ImgUrl = "images/ghanaBasket2.jpg" },
            new Products {Id = 9, Name ="Luke Mino", Country="Made in Philippines", Description = "Philippines hand-craft Basket weaving.", Price = 100, ImgUrl = "images/basket2.jpg" },

           
            new Products {Id = 10, Name ="Thandi Nkosi ", Country="Made in South Africa", Description = "South African hand-craft beaded jewellery.", Price = 80, ImgUrl = "images/SAbeads.jpg" },
            new Products {Id = 11, Name ="Grace Gumalo ", Country="Made in Nigeria",Description = "Nigeria beaded bracelets.", Price = 60, ImgUrl = "images/beads.jpg" },
            new Products {Id = 12, Name ="Lucy Smith", Country="Made in America", Description = "Native American beaded phone covers.", Price = 250, ImgUrl = "images/beadPhone.jpg" },

            
            new Products {Id = 13, Name ="Thabo Zama ", Country="Made in Ghana", Description = "Wooden African continent.", Price = 300, ImgUrl = "images/ghanaWood.jpg" },
            new Products {Id = 14, Name ="Chen Lee ", Country="Made in Japan", Description = "Japanse wooden elephant frame.", Price = 450, ImgUrl = "images/elephantWood.jpg" },
            new Products {Id = 15, Name ="Tom Gray", Country="Made in Canada", Description = "Canadian wooden duct frame.", Price = 300, ImgUrl = "images/birdWood.jpg" },


            
            new Products {Id = 17,Name ="Jack Doros", Country="Made in Morocco", Description = "Silver metal horse ornament.", Price = 100, ImgUrl = "images/horseMetal.jpg" },
            new Products {Id = 18, Name ="Mandy Dawson ", Country="Made in Germany", Description = "Germann colourful butterfly brooch.", Price = 75, ImgUrl = "images/metalButterfly.jpg" },
            new Products {Id = 19, Name =" Thato Zama", Country="Made in South Africa", Description = "Metal musician ornament", Price = 100, ImgUrl = "images/saMetal.jpeg" }

            };


            return View(products);
           
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}
