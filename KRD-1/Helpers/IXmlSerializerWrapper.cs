using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRD_1.Wrappers
{
    public interface IXmlSerializerWrapper
    {
       void Deserialize(StreamReader stream);
    }
}
