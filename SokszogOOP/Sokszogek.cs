using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Sokszogek
    {
        private List<Sokszog> sokszogek;
        private static Random random = new Random();

        public Sokszogek()
        {
            sokszogek = new List<Sokszog>();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(3);
                switch (randomNumber)
                {
                    case 0:
                        sokszogek.Add(new Paralelogramma());
                        break;
                    case 1:
                        sokszogek.Add(new Haromszog());
                        break;
                    case 2:
                        sokszogek.Add(new Teglalap());
                        break;
                    default:
                        break;
                }
            }
        }

        public double OsszKerulet()
        {
            double osszKerulet = 0;
            foreach (var item in sokszogek)
            {
                osszKerulet += item.GetKerulet();
            }
            return osszKerulet;
        }
        public double OsszTerulet()
        {
            double osszTerulet = 0;
            foreach (var item in sokszogek)
            {
                osszTerulet += item.GetTerulet();
            }
            return osszTerulet;
        }
        public int MaxTerulet()
        {
            double maxTerulet = sokszogek[0].GetTerulet();
            int index = 0;
            for (int i = 0; i < sokszogek.Count; i++)
            {
                if (maxTerulet < sokszogek[i].GetTerulet())
                {
                    maxTerulet = sokszogek[i].GetTerulet();
                    index = i;
                }
            }
            return index + 1;
        }
        public override string ToString()
        {
            var sb = new StringBuilder("Sokszögek:");
            foreach (var sokszog in sokszogek)
            {
                sb.AppendLine();
                sb.AppendLine($"\t{sokszog.ToString()}");
            }
            return sb.ToString();
        }
    }
}
