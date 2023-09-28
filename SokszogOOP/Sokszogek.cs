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
