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
        public IActionResult AddCarToBasket(int idCar)
        {
           
            Basket basket;
            if (this.HttpContext.Session.GetString("BASKET") == null)
                basket = new Basket();
            else
            {
                basket = JsonConvert.DeserializeObject<Basket>(this.HttpContext.Session.GetString("BASKET"));

            }
            basket.AddCar(idCar);
            var json = basket.ToJson();
            this.HttpContext.Session.SetString("BASKET",json);
            return Ok(json);
        }
    }
}
