﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Halasi-Czalbert Tibor

            Haromszog haromszog = new Haromszog();
            Haromszog haromszog2 = new Haromszog(3, 4, 5);
            Teglalap teglalap = new Teglalap(3, 5);
            Teglalap teglalap2 = new Teglalap(4, 2);

            Console.WriteLine(haromszog);
            Console.WriteLine(haromszog2);
            Console.WriteLine(teglalap);
            Console.WriteLine(teglalap2);

            //Console.WriteLine(haromszog2.A);
            //try
            //{
            //    haromszog2.A = 10;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine(haromszog2.A);

            Paralelogramma paralelogramma = new Paralelogramma();
            Console.WriteLine(paralelogramma);

            Console.WriteLine("\n----------------------------------------------\n");
            Sokszogek sokszogek = new Sokszogek();
            Console.WriteLine(sokszogek);
            Console.WriteLine("\nÖsszterület: " + sokszogek.OsszKerulet());
            Console.WriteLine("Összkerület: " + sokszogek.OsszTerulet());
            Console.WriteLine($"Legnagyobb területe a {sokszogek.MaxTerulet()}. elemnek van.");

            Console.ReadKey();
        }
    }
}
