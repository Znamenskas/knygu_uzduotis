using System;
namespace knygosUzduotis
{
    public class Knygos
    {
        private string isbn;
        private string pavdinimas;
        private string autorius;
        private int leidimoMetai;
        private string leidejas;
        private string salis;
        private decimal kaina;

        
        // KONSTRUKTORIAI.

        public Knygos(string isbn, string pavdinimas, string autorius, int leidimoMetai, string leidejas, string salis, decimal kaina)
        {
            this.Isbn = isbn;
            this.Pavdinimas = pavdinimas;
            this.Autorius = autorius;
            this.LeidimoMetai = leidimoMetai;
            this.Leidejas = leidejas;
            this.Salis = salis;
            this.Kaina = kaina;
        }

        public Knygos()
        {
        }
        // GETERIAI SETERIAI.

        public string Isbn { get => isbn; set => isbn = value; }
        public string Pavdinimas { get => pavdinimas; set => pavdinimas = value; }
        public string Autorius { get => autorius; set => autorius = value; }
        public int LeidimoMetai { get => leidimoMetai; set => leidimoMetai = value; }
        public string Leidejas { get => leidejas; set => leidejas = value; }
        public string Salis { get => salis; set => salis = value; }
        public decimal Kaina { get => kaina; set => kaina = value; }

        public override string ToString()
        {
            // Overridintas ToString() metodas.

            string tekstas = " isbn: " + isbn + "; Pavadinimas: " + pavdinimas + "; Autorius: " + autorius + "; Leidimo metai: " + leidimoMetai + "; Leidejas: " + leidejas + "; Salis: " + salis + "; Kaina: " + kaina;

            return tekstas;
        }
    }
}
