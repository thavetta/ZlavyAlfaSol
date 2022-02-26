using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlavyAlfa
{
    public abstract class ZlavyBase
    {
        public decimal ZakladnaJednotkovaCenaBezDPH { get; set; }

        public virtual decimal VyslednaJednotkovaCenaBezDPH
        {
            get
            {
                return ZakladnaJednotkovaCenaBezDPH;
            }
        }
        public decimal Mnozstvo { get; set; }
        public int KodDPH { get; set; }
        public int Poradie { get; set; }

        
    }
}
