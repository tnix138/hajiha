using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashin_hesab_T3ohid
{
    class Masihn_Hesab : IRole
    {
        public int jame(int num1, int num2)
        {
            return num1 + num2;
        }

        public int tafrig(int num1, int num2)
        {
            return num1 - num2;
        }

        public int tagsim(int num1, int num2)
        {
            return num1 / num2;
        }

        public int zarb(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
