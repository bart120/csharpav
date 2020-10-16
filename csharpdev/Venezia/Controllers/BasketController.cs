using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Venezia.Models;

namespace Venezia.Controllers
{
    public class BasketController : Controller
    {
        [HttpPost]
        public JsonResult AddCarToBasket(int idCar)
        {
            Basket basket;
            if (this.HttpContext.Session.GetString("BASKET") == null)
                basket = new Basket();
            else
                basket = JsonConvert.DeserializeObject<Basket>(this.HttpContext.Session.GetString("BASKET"));
            
                
            basket.Cars.Add(idCar);
            this.HttpContext.Session.SetString("BASKET",JsonConvert.SerializeObject(basket));
            return Json(basket);
        }
    }
}
