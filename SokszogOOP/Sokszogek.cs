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
        private List<Sokszog> sokszogek = new List<Sokszog>();
        static Random random = new Random();

        public Sokszogek() 
        {
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0,3);
                switch (randomNumber) 
                {
                    case 0:
                        Paralelogramma paralelogramma = new Paralelogramma();
                        sokszogek.Add(paralelogramma);
                        break;
                    case 1:
                        Haromszog haromszog = new Haromszog();
                        sokszogek.Add(haromszog);
                        break;
                    case 2:
                        Teglalap teglalap = new Teglalap(5,15);
                        sokszogek.Add(teglalap);
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
            return index+1;
        }
        public override string ToString()
        {
            string tartalom = "";
            foreach (var item in sokszogek)
            {
                tartalom += item + "\n";
            }
            return tartalom;
        }
    }
}
