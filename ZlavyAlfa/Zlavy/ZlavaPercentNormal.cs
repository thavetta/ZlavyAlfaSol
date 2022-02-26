using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlavyAlfa.Zlavy
{
    public class ZlavaPercentNormal : ZlavaDecorator
    {
        public override decimal VyslednaJednotkovaCenaBezDPH
        {
            get
            {
                var cena = zaklad.VyslednaJednotkovaCenaBezDPH;
                return cena - cena * ZlavaPercent;
            }
        }
    }
}
