using System;
using System.Collections.Generic;
using System.Linq;

namespace knygosUzduotis
{
    class Program
    {
        // CIA YRA PASTOVUS KINTAMIEJI / REIKSMES (konstantos) , pvz.: failo pavadinimas.

        const string FailoPavadinimas = "knygos.csv";

        static void Main(string[] args)
        {
            //Knygos knygos = new Knygos("95 - 6351 - 575 - 7", "El Sanción Creyente", "Turner Sandoval Loya", 1944," Línea Editorial","Chile", 56.8m);

            //Console.WriteLine(knygos.ToString());
               NuskaitytiKnygosIsFailo();
        }

        static List<Knygos> NuskaitytiKnygosIsFailo()
        {
            List<Knygos> knygos = new List<Knygos>();
            string[] eilutes = System.IO.File.ReadAllLines(FailoPavadinimas);



            foreach (string eilute in eilutes.Skip(1).ToArray())
            {
                //Console.WriteLine(eilute);

                knygos.Add(KonvertuojaEiluteIknygos(eilute));
                
            }
            return knygos;


        }

        static Knygos KonvertuojaEiluteIknygos(string eilute) 
        {
            string[] stulpeliai = eilute.Split(",");

            Knygos knygos = new Knygos();

            Console.WriteLine(stulpeliai[0]);
            Console.WriteLine(stulpeliai[1]);
            Console.WriteLine(stulpeliai[2]);
            Console.WriteLine(stulpeliai[3]);
            Console.WriteLine(stulpeliai[4]);
            Console.WriteLine(stulpeliai[5]);
            Console.WriteLine(stulpeliai[6]);

            knygos.Isbn =  stulpeliai[0];
            knygos.Pavdinimas = stulpeliai[1];
            knygos.Autorius = stulpeliai[2];
            knygos.LeidimoMetai = Convert.ToInt32(stulpeliai[3]);
            knygos.Leidejas = stulpeliai[4];
            knygos.Salis = stulpeliai[5];
            knygos.Kaina = Convert.ToDecimal(stulpeliai[6]);

            return knygos;
        }
    }
}
