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
        if (Vzdalenost)
            {

            }
        }
        public void Naloz()
        {

        }
        public void Tankovat()
        {
            Palivo += input;
            if (Palivo > ObjemNadrz)
            {
                Palivo = ObjemNadrz;
            }
        }
        public
    }
    
}
