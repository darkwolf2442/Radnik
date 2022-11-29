using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public abstract class Radnik
    {
        private string ime;
        private double procenat;
        protected Radnik(string i, double p) 
        {
            ime = i;
            procenat = p;
        }
        public abstract double Prihod { get; }
        public double Plata { get { return Prihod * procenat / 100; } }
        public override string ToString()
        {
            return ime + "/"+ Plata;
        }
    }
}
