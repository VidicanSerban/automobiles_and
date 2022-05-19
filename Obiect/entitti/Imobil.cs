using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Imobil : Elemente
    {
        public string Tip { get; set; }
        public float Area { get; set; }
        public int Rooms { get; set; }

        public Imobil(float pret, string tel, string tip, float area, int rooms)
            :base(pret, tel)
        {
            Tip = tip;
            Area = area;
            Rooms = rooms;
        }
    
        public override string Descriere()
        {
            return $"Pretul imobilului:{Pret} - Numarul de contact {Tel}. Acesta este un imobil de tip {Tip}, cu suprafata de {Area} metrii patrati si {Rooms} camere.";
        }
    }
}
