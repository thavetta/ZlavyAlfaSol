using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlavyAlfa
{
    public class ZakladCeny : ZlavyBase
    {
        public ZakladCeny()
        {
            this.Poradie = 1;
        }

        public override string ToString()
        {
            return TextUI + " - " + ZakladnaJednotkovaCenaBezDPH;
        }
    }
}
