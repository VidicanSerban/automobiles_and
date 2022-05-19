using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace Obiect
{
    class Program
    {
        static void Main(string[] args)
        {
            var ziar = new ObiectMgr();
            Console.Write("Cate masini doriti sa introduceti in anunt? - ");
            int nr_masini = int.Parse(Console.ReadLine());
            for (int i = 0; i < nr_masini; i++)
            {
                ziar.AddElement(new MasinaMgr().AddMasina());
            }
            Console.Write("Cate imobile doriti sa introduceti in anunt? - ");
            int nr_imob = int.Parse(Console.ReadLine());
            for (int i = 0; i < nr_imob; i++)
            {
                ziar.AddElement(new ImobilMgr().AddImobil());
            }

            ObiectMgr.PrintLista();
            //ObiectMgr.QueryMarca();
            //Console.WriteLine("Cartea cu titlul " + title + " a fost imprumutata!");
            //ObiectMgr.PrintLista();
        }
    }
}
