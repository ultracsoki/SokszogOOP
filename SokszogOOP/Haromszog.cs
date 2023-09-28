using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Haromszog : Sokszog
    {
        private static Random random = new Random();
        private double b;
        private double c;

        public Haromszog(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
        }

        public Haromszog() : base(VeletlenOldalhossz())
        {
            this.b = VeletlenOldalhossz();
            this.c = VeletlenOldalhossz();
        }

        private static int VeletlenOldalhossz()
        {
            return random.Next(5, 15);
        }

        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double GetKerulet()
        {
            return this.A + this.b + this.c;
        }

        public double GetTerulet()
        {
            double s = GetKerulet() / 2;
            return Math.Sqrt(s * (s - this.A) * (s - this.b) * (s - this.c));
        }

        public override string ToString()
        {
            return $"a:{this.A}  b:{this.b}  c:{this.c}  Kerület:{GetKerulet()}  Terület:{GetTerulet()}";
        }
    }
}
