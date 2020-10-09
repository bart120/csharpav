using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Venezia.Models
{
    public class Car
    {
        public int ID { get; set; }

        [Display(Name ="Marque", Prompt = "Marque du véhicule")]
        public string Mark { get; set; }

        [Display(Name = "Modèle", Prompt = "Modèle du véhicule")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public string Model { get; set; }

        [Display(Name = "Tarif", Prompt = "Tarif du véhicule")]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }

        [Display(Name = "Carburant", Prompt = "Carburant du véhicule")]
        public Fuel FuelType { get; set; }

        [Display(Name = "Voiture autonome")]
        public bool Autonomous { get; set; }
    }

    public enum Fuel
    {
        Gasoline,
        Diesel
    }
}
