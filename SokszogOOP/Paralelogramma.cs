using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Paralelogramma : Teglalap
    {
        private static Random random = new Random();
        private double alfa;


        public Paralelogramma(double a, double b, double alfa) : base(a, b)
        {
            if (alfa >= 180)
            {
                throw new ArgumentException("Az oldalak által közbezárt szög nem lehet 180°-nál nagyobb.", nameof(alfa));
            }
            this.alfa = alfa;
        }

        public Paralelogramma() : base(VeletlenOldalhossz(), VeletlenOldalhossz())
        {
            base.A = VeletlenOldalhossz();
            base.B = VeletlenOldalhossz();
            this.alfa = VeletlenSzog();
        }

        public double Alfa
        {
            get => alfa;
            set
            {
                if (value >= 180)
                {
                    throw new ArgumentException("Az oldalak által közbezárt szög nem lehet 180°-nál nagyobb.", nameof(value));
                }
                alfa = value;
            }
        }

        //Nincs értelme ideírni, ha az ős-osztályban szerepel és nem akarom felülírni
        //public override double GetKerulet()
        //{
        //    return base.GetKerulet();
        //}

        public override double GetTerulet()
        {
            //return this.A * this.B * Math.Sin(this.alfa / 180 * Math.PI);
            return base.GetTerulet() * FokbolRadianba(this.alfa);
        }

        public override string ToString()
        {
            return $"{base.ToString()}  Alfa: {this.alfa}°";
        }
    }
}
