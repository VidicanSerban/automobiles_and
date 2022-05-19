using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace Obiect
{
    public class ImobilMgr
    {
        public Imobil AddImobil()
        {
            Console.WriteLine("Pret: ");
            float pret = float.Parse(Console.ReadLine());
            Console.WriteLine("Tel: ");
            string tel = Console.ReadLine();
            Console.WriteLine("Tip: ");
            string tip = Console.ReadLine();
            Console.WriteLine("Suprafata: ");
            float suprafata = float.Parse(Console.ReadLine());
            Console.WriteLine("Numarul de camere: ");
            int camere = int.Parse(Console.ReadLine());

            return new Imobil(pret, tel, tip, suprafata, camere);
        }
    }
}
