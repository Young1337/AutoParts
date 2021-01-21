using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParts.Models.Entities
{
    public class Request
    {
        [Key]
        public int Id { get; set; }        
        public string Detail { get; set; }
        public string Note { get; set; }
        public string Сontacts { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
