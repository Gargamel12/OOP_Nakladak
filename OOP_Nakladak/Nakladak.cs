using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nakladak
{
    public class Nakladak
    {
        public Nakladak(int nosnost, int objem,  int spotreba )
        {
            Znacka = "";
            Nosnost = nosnost;
            Nalozeno = 0;
            ObjemNadrz = objem;
            Palivo = 0;
            Spotreba = spotreba;
            Vzdalenost = 0;
        }

        public string Znacka { get; set; }
        public int Nosnost { get; set; }
        public int Nalozeno { get; set; }
        public int ObjemNadrz { get; set; }
        public int Palivo { get; set; }
        public int Spotreba { get; set; }
        public int Vzdalenost { get; set; }

        public void Jet(int Vzdalenost) 
        {

        }
        public void Naloz(int Nalozeni)
        {
            
            if (Nalozeno > Nosnost)
            {
                Nalozeno = Nosnost;
            }
            if (Nalozeno < 0)
            {
                Nalozeno = 0;
            }
        }
        public void Vyloz(int vylozeni)
        {

            if (Nalozeno < 0) ;
        }
        public void Tankovat(int palivo)
        {

            Palivo += palivo;
            if (Palivo > ObjemNadrz)
            {
                Palivo = ObjemNadrz;
            }
        }
        
    }
    
}
