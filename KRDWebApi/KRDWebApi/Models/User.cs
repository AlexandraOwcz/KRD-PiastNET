using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KRDWebApi.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        public String Surname { get; set; }
        public String Street { get; set; }
        public Char Gender { get; set; }
        public String Country { get; set; }
    }
}
