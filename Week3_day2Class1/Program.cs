using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day2Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testScores = new List<int>() { 100, 73, 89, 94, 96 };
            //testScores.Add(80);
            //testScores.Add(99);

            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(2);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(5);
            //luckyNumbers.Add(7);
            //luckyNumbers.Add(1);
            //Console.WriteLine(luckyNumbers.Count);



            //List<string> favFoods = new List<string>() { "steak", "shrimp", "Lobster", "Dip n Dots", "funnel cake" };

            ////Check you list by printing each element individually
            //Console.WriteLine(favFoods[0]);
            //Console.WriteLine(favFoods[1]);
            //Console.WriteLine(favFoods[2]);
            //Console.WriteLine(favFoods[3]);
            //Console.WriteLine(favFoods[4]);



            //List<string> leastfavFoods = new List<string>();
            //leastfavFoods.Add("Peanuts");
            //leastfavFoods.Add("chitlens");
            //leastfavFoods.Add("Liver");
            //Console.WriteLine(leastfavFoods[0]);

            //leastfavFoods[0] = "Olives";
            //Console.WriteLine(leastfavFoods[0]);


            List<string> faveFilms = new List<string>() { "Lion King", "Space Jam", "Stomp The Yard", "The Iron Giant", "Howl's Moving Castle" };

            for (int i = 0; i < faveFilms.Count; i++)
            {
                Console.WriteLine(faveFilms[i]);

            }

            faveFilms.Insert(0, "The Road to Elderado");
            faveFilms.Insert(1, "All Dogs go to Heaven");
            faveFilms.Insert(2, "My Neighbor Totoro");

            Console.WriteLine();

            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            faveFilms.Remove("Space Jam");
            faveFilms.Remove("All Dogs go to Heaven");

            Console.WriteLine();

            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }


            //List<string> faveAnimal = new List<string>();
            //faveAnimal.Add("Dire Wolf");
            //faveAnimal.Add("Puppy");
            //faveAnimal.Add("Kowala");
            //faveAnimal.Add("Panda");
            //faveAnimal.Add("Whale");

            //for (int i = 0; i < faveAnimal.Count; i++)
            //{
            //    Console.WriteLine(faveAnimal[i]);
            //}

            //List<bool> rainyDay = new List<bool>() { true, false, false, true, false };
            //for (int i = 0; i < rainyDay.Count; i++)
            //{
            //    Console.WriteLine(rainyDay[i]);

            //    if (rainyDay[i])
            //    {
            //        Console.WriteLine("better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun!");
            //    }

                
            }
        }
    }
}