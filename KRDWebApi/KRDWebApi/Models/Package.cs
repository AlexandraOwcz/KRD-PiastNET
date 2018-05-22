using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KRDWebApi.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }
        public String Status { get; set; }
        public String Hour { get; set; }
    }
}
