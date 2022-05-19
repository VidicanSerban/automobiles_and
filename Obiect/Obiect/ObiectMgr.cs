using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace Obiect
{
    class ObiectMgr
    {
        public static List<Elemente> imobile_masini = new List<Elemente>();

        public void AddElement(Elemente elem)
        {
            imobile_masini.Add(elem);
        }

        public static void PrintLista()
        {
            foreach (var elem in imobile_masini)
            {
                Console.WriteLine(elem.Descriere());
            }
        }
        
        /*public static void QueryMarca()
        {
            int nr_m = 0;
            var listaMasini = imobile_masini.Where(e => e.GetType().Equals(typeof(Masina)));
            var test = listaMasini as IEnumerable<Masina>;
            var x = test.Where(t => t.Marca == "BMW");
            foreach (var elem in x)
            {
                Console.WriteLine(elem.Descriere());
                nr_m++;
            }
            Console.WriteLine("Numarul de masini marca BMW este " + nr_m);
        }*/

    }
}
