using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParts.Models.ViewModels
{
    public class RequestModel
    {
        [Required(ErrorMessage = "Не указана деталь")]
        public string Detail { get; set; }
        [Required(ErrorMessage = "Не указаны примечания")]
        public string Note { get; set; }                
        [Required(ErrorMessage = "Не указаны контакты")]
        public string Сontacts { get; set; }        
    }
}
