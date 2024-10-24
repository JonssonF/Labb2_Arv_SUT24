using Labb2_Arv_SUT24.Superclass;

namespace Labb2_Arv_SUT24 // Fredrik Jonsson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\tLABB 2 :: ARV\n\n" +
            "Var vänlig tryck på valfri knapp för att gå igenom djuren och deras beteende.\n");
            Console.ReadKey();
            Console.Clear();
            DisplayRabbit();
            Console.ReadKey();
            Console.Clear();
            DisplayBird();



        }
        public static void DisplayRabbit()
        {
            // Name, Gender, Age, Weight, nrLegs, meatEater?, isWild?, isPrey?
            var rabbit = new Rabbit("Bunny", "Male", 6, 8, 4, false, true, true);
            var rabbit1 = new Rabbit("Bunnie", "Female", 4, 6, 4, false, false, false);

            Console.WriteLine("\t\tR A B B I T:\n");

            rabbit.IsHunted();
            rabbit1.IsHunted();
            Console.WriteLine(" ");

            rabbit.Plays();
            rabbit1.Plays();
            Console.WriteLine(" ");

            rabbit.Eat();
            rabbit1.Eat();
            Console.WriteLine(" ");            
                        
            rabbit.MakeSound();
            rabbit1.MakeSound();
            Console.WriteLine(" ");
            
            rabbit.Tame();
            rabbit1.Tame();
            Console.WriteLine(" ");

            rabbit.Mate();
            rabbit1.Mate();
            Console.WriteLine(" ");

            rabbit.Sleep();
            rabbit1.Sleep();
            Console.WriteLine(" ");
            
            Console.ReadLine();
        }
        public static void DisplayBird()
        {



            Console.ReadLine();

        }
    }
    
}
