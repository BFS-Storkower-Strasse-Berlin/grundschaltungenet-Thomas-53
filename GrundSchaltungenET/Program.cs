using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundSchaltungenET
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<double> list = new List<double>();
            bool status = true;
            while (status)
            {
                Console.WriteLine("Gib mir einen Widerstand!");
                string test = Console.ReadLine();
                list.Add(double.Parse(test));


                Console.WriteLine("Möchtest du noch einen Widerstand eingeben ? (j/n)");
                test = Console.ReadKey().KeyChar.ToString();
                if (!test.Contains("j"))
                    status = false;
                Console.WriteLine();
            }




            Console.WriteLine("Geben sie eine Spannung ein:");
            string eingabeV = Console.ReadLine();

            Console.WriteLine("");



            Console.WriteLine("\nWiderstände in der Reiehnschaltung:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + " " + list[i] + " Ohm");
            }


            Console.WriteLine("\nWiderstände in der Parallelschaltung:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + " " + list[i] + " Ohm");
            }


            string Reihe = ("\nErgebnisse für die Reihenschaltung:");
            Console.WriteLine(Reihe);


            double rGesReihe = 0;
            for (int i = 0; i < list.Count; i++)
            {
                rGesReihe = rGesReihe + list[i];
            }
            Console.WriteLine("rGesReihe : " + rGesReihe + " Ohm");




            float spannung = float.Parse(eingabeV);
            double iGesReihe = spannung / rGesReihe;
            Console.WriteLine("iGesReihe : " + iGesReihe + " A ");








            //float widerstand1 = float.Parse(eingabeR1);
            //float widerstand2 = float.Parse(eingabeR2);
            //float spannung    = float.Parse(eingabeV); 

            //float GesamtWiderstandReihe = widerstand1 + widerstand2;
            //float GesamtStromReihe = spannung / GesamtWiderstandReihe;
            //float TeilSpannungReihe1 = widerstand1 * GesamtStromReihe;
            //float TeilSpannungReihe2 = widerstand2 * GesamtStromReihe;


            //string Reihe = ("Ergebnisse für die Reihenschaltung:");


            //Console.WriteLine(Reihe);
            //Console.WriteLine("R1 = "+ eingabeR1 +" Ohm");
            //Console.WriteLine("R2 = "+ eingabeR2 +" Ohm");
            //Console.WriteLine("Rges = " + GesamtWiderstandReihe + " Ohm");
            //Console.WriteLine("I = " + GesamtStromReihe + " A");
            //Console.WriteLine("I1 = "+ GesamtStromReihe + " A");
            //Console.WriteLine("I2 = " + GesamtStromReihe + " A");
            //Console.WriteLine("U = " + eingabeV + " V");
            //Console.WriteLine("U1 = " + TeilSpannungReihe1 + " V");
            //Console.WriteLine("U2 = " + TeilSpannungReihe2 + " V");


            //float TeilstromParallel1 = spannung / widerstand1;
            //float TeilstromParallel2 = spannung / widerstand2;
            //float GesamtwiderstandParallel = 1 / ((1 / widerstand1) + (1 / widerstand2));
            //float GesamtStromParallel = TeilstromParallel1 + TeilstromParallel2;
            //float TeilSpannungParallel1 = widerstand1 * TeilstromParallel1;
            //float TeilSpannungParallel2 = widerstand2 ;



            //string Parallel = ("Ergebnisse für die Parallelschaltung:");
            //Console.WriteLine("");
            //Console.WriteLine(Parallel);
            //Console.WriteLine("R1 = " + eingabeR1 + " Ohm");
            //Console.WriteLine("R2 = " + eingabeR2 + " Ohm");
            //Console.WriteLine("Rges = " + GesamtwiderstandParallel + " Ohm");
            //Console.WriteLine("I = " + GesamtStromParallel + " A");
            //Console.WriteLine("I1 = " + TeilSpannungParallel1);
            //Console.WriteLine("I2 = " + TeilSpannungParallel2);
            //Console.WriteLine("Uges = " + eingabeV + " V");
            //Console.WriteLine("U1 = " + eingabeV + " V");
            //Console.WriteLine("U2 = " + eingabeV + " V");


            Console.ReadKey();









        }

    }
}
