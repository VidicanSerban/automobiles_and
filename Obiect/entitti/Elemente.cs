using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public abstract class Elemente
    {

        public float Pret { get; set;}
        public string Tel { get; set;}
        public Elemente(float pret, string tel)
        {
            Pret = pret;
            Tel = tel;
        }

        public abstract string Descriere();
    }
}
