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

        public Paralelogramma()
        {
            base.A = VeletlenSzam();
            base.B = VeletlenSzam();
            this.alfa = VeletlenSzam();
        }

        public double Alfa { get => alfa; set => alfa = value; }

        private static double VeletlenSzam()
        {
            return random.Next(5, 15);
        }

        //public override double GetKerulet()
        //{
        //    return base.GetKerulet();
        //}

        public override double GetTerulet()
        {
            return this.A * this.B * Math.Sin(this.alfa/180*Math.PI);
        }
    }
}
