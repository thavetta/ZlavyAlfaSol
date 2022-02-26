namespace ZlavyAlfa.Zlavy
{
    public abstract class ZlavaDecorator : ZlavyBase
    {
        protected ZlavyBase zaklad;

        public decimal ZlavaPercent { get; set; }
        public decimal ZlavaFix { get; set; }

        public decimal ZlavaCelkom => zaklad.VyslednaJednotkovaCenaBezDPH - VyslednaJednotkovaCenaBezDPH;

 

        public ZlavyBase InsertPocitacZliav(ZlavyBase zaklad, ZlavaDecorator nadradeny = null)
        {
            if (zaklad.Poradie < this.Poradie)
            {
                this.zaklad = zaklad;
                if (nadradeny == null) return this;
                nadradeny.zaklad = this;
                return nadradeny;
            }

            var vnutro = zaklad as ZlavaDecorator;

            this.InsertPocitacZliav(vnutro.zaklad, vnutro);

            return zaklad;
        }

        public override string ToString()
        {
            return zaklad.ToString() + "\n" + TextUI + " - " + ZlavaCelkom;
        }
    }
}