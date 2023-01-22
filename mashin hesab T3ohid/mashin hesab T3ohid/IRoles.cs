using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashin_hesab_T3ohid
{
    interface IRole
    {
        ///کد جمع زدن
        int jame(int num1, int num2);
        // کد تفریق
        int tafrig(int num1, int num2);
        //کد ضرب
        int zarb(int num1, int num2);
        // کد تقسیم
        int tagsim(int num1, int num2);

    }
}
