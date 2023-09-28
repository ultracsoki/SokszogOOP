using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Haromszog : Sokszog
    {
        private double b;
        private double c;

        public Haromszog(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
        }

        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double getKerulet()
        {
            return this.A + this.b + this.c;
        }
        
        public double getTerulet()
        {
            return Math.Sqrt((getKerulet() / 2) * (getKerulet() - this.A) * (getKerulet() - this.b) * (getKerulet() - this.c));
        }
    }
}
