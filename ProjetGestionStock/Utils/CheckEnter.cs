using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionStock.Utils
{
    public static class CheckEnter
    {
        public static bool checkIsNumber(string number)
        {
            int n;
            return int.TryParse(number , out n);
        }
        public static bool checkIsFloat(string number)
        {
            float n;
            return float.TryParse(number, out n);
        }
       
    }
}
