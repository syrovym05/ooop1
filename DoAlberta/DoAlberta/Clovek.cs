using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAlberta
{
    class Clovek
    {
        private string jmeno;
        private DateTime narozen;
       

        public Clovek(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }

        public void NastavJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public string VypisJmeno()
        {
            return this.jmeno;
        }

        public int Vek()
        {
            TimeSpan vek = DateTime.Now - narozen;                 
            return Convert.ToInt32(Math.Floor(vek.TotalDays / 365.24));                        
        }

        public bool Plnolety()
        {            
            if (Vek() >= 18) return true;            
            else return false;           
        }

        public string Starsi(Clovek clovek)
        {
            if(narozen == clovek.narozen) return this.jmeno + " a " + clovek.jmeno + " jsou stejne staří";

            if(narozen < clovek.narozen)
            {
                return this.jmeno + " je starsi nez " + clovek.jmeno;
            }
            else return "" + clovek.jmeno + " je starsi nez " + this.jmeno;
        }

        public override string ToString()
        {
            return Plnolety() ? this.jmeno + " má " + Vek() + " a je plnolety" : this.jmeno + " má " + Vek() + " a neni plnolety";
         
        }

    }
}
