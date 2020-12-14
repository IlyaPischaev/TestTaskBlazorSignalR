using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorCity.Shared.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Введите название города")]
        public string CityName { get; set; }

        [Range(1, 1000000000, ErrorMessage = "Невозможные данные данные по населению (в пределах от 1 человека до 1 миллиарда людей)")]
        public int CityPopulation { get; set; }
        public int CityFoundationYear { get; set; }
        public int CityDoundationMonth { get; set; }
        public int CityDoundationDay { get; set; }
    }
}
