using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Paralelogramma : Teglalap
    {
        private static Random random = new Random();
        private double alfa;


        public Paralelogramma(double a, double b, double alfa) : base(a,b)
        {
            this.alfa = alfa;
        }

        public Paralelogramma() : base(VeletlenSzam(),VeletlenSzam())
        {
            base.A = VeletlenSzam();
            base.B = VeletlenSzam();
            this.alfa = VeletlenSzam()*6;
        }

        public double Alfa { get => alfa; set => alfa = value; }

        private static double VeletlenSzam()
        {
            return random.Next(5, 15);
        }
        //Nincs értelme ideírni, ha az ős-osztályban szerepel és nem akarom felülírni
        //public override double GetKerulet()
        //{
        //    return base.GetKerulet();
        //}

        public override double GetTerulet()
        {
            return this.A * this.B * Math.Sin(this.alfa/180*Math.PI);
        }

        public override string ToString()
        {
            return $"{base.ToString()}  Alfa: {this.alfa}";
        }
    }
}
