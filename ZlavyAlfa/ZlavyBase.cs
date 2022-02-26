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
        public string TextUI { get; set; }
        public string TextPOS { get; set; }

        private int poradie;

        public int Poradie
        {
            get => poradie;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Poradie", "Poradie nesmie byť menšie než 1");
                poradie = value;
            }
        }

        
    }
}
