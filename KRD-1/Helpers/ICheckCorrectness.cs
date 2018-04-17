using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRD_1
{
    public interface ICheckCorrectness
    {
        bool ContainsNumber(String text);
        bool ContainsOnlyLetters(String text);
    }
}
