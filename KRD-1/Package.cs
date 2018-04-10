using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRD_1
{
    [Serializable()]
    public class Package
    {
        public int Id { get; set; }
        public String Status { get; set; }
        public String Hour { get; set; }
    }
}
