using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal abstract class Sokszog
    {
        private double a;
        private static Random random = new Random();

        public Sokszog(double a)
        {
            this.a = a;
        }

        public virtual double A { get => a; set => a = value; }

        public abstract double GetKerulet();
        public abstract double GetTerulet();

        protected static int VeletlenOldalhossz()
        {
            return random.Next(0, 100);
        }

        protected static int VeletlenSzog()
        {
            return random.Next(1, 180);
        }

        protected static double FokbolRadianba(double fok)
        {
            return fok * Math.PI / 180;
        }

        public override string ToString()
        {
            return $"Kerület: {this.GetKerulet()}  Terület: {this.GetTerulet()}";
        }
    }
}
