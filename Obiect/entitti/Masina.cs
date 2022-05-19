using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Masina : Elemente
    {
        public string Marca { get; set; }
        public int An { get; set;}

        public Masina(float pret, string tel, string marca, int an)
            :base(pret, tel)
        {
            Marca = marca;
            An = an;
        }

        public override string Descriere()
        {
            return $"Pretul autoturismului:{Pret} - Numarul de contact {Tel}. Acesta este un autoturism marca {Marca} fabricat in anul {An}.";
        }

        
    }
}
