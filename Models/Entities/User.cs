using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParts.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
       // [Required]
        public string Name { get; set; }
       // [Required]
        public int Age { get; set; }
       // [Required]
        public string Phone { get; set; }
       // [Required]
        public string Login { get; set; }
       // [Required]
        public string Pass { get; set; }
        //[Required]
        public string Address { get; set; }
        public DateTime DateReg { get; set; }        
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }

}
