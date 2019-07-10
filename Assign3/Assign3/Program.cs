using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tp = new TextProcessing();
            //tp.Run();
            //Blue b1 = new Blue();
            //b1.SayFavoriteFood(Red.FavoriteFood);
            new Blue().SayFavoriteFood(Red.FavoriteFood);
        }
    }



    class TextProcessing
    {
        Queue<string> names = new Queue<string>();
        public void Run()
        {
            // Open the names file and access the data
            using (StreamReader file = new StreamReader("U:/Users/739414/Assign3/Assign3/Assign3/names.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                // post condition of while is:
                //we now have a data member named names which is a queue!!!!!!
                PlayWithStacks.Run(names);
            }
        }
    }
    class PlayWithStacks
    {
        public static void Run(Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();
            //how can I access the queue variables "names" here in this class?????
            //iterate OVER our Queue
            //get each element
            //push it into the Stack
            foreach (var item in tangerine)
            {
                names.Push(tangerine.Dequeue());

            }
        }
    }
    class Workbench { }
    class Red
    {
        public static string FavoriteFood = "carrots";

    }
    class Blue
    {
        public void SayFavoriteFood(string FavFood)
        {
            Console.WriteLine(Red.FavoriteFood);
        }
    }

}