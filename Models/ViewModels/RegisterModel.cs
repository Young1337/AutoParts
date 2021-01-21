using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParts.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан возраст")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Не указан Адрес")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Не указан телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        [DataType(DataType.Password)]
        [Compare("Pass", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
