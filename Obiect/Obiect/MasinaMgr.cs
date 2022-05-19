using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace Obiect
{
    public class MasinaMgr
    {
        public Masina AddMasina()
        {
            Console.WriteLine("Pret: ");
            float pret = float.Parse(Console.ReadLine());
            Console.WriteLine("Tel: ");
            string tel = Console.ReadLine();
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Anul fabricatiei: ");
            int an = int.Parse(Console.ReadLine());

            return new Masina(pret, tel, marca, an);
        }

        
    }
}
