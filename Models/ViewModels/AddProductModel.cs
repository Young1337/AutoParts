using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoParts.Models.ViewModels
{
    public class AddProductModel
    {
       // [Required(ErrorMessage = "Не указан логин")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Не указано имя")]
        public int Price { get; set; }
        //[Required(ErrorMessage = "Не указан возраст")]
        public int Amount { get; set; }
        //[Required(ErrorMessage = "Не указан Адрес")]
        public string CountryManufactur { get; set; }
        //[Required(ErrorMessage = "Не указан телефон")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "Не указан категория")]
        public int CategoryId { get; set; }
        //[Required(ErrorMessage = "Не указан фото")]
        public string Image { get; set; }
    }
}
