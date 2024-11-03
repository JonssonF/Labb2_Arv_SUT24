using Labb2_Arv_SUT24.Subclass;
using Labb2_Arv_SUT24.Superclass;

namespace Labb2_Arv_SUT24 // Fredrik Jonsson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different methods to step through the animals in the program.
            Console.WriteLine("\t\tLABB 2 :: ARV\n\n" +
            "Press any key to watch some animals and a selection of their behaviours.\n");
            Console.ReadKey();
            Console.Clear();

            DisplayRabbit();
            Console.ReadKey();
            Console.Clear();

            DisplayBird();
            Console.ReadKey();
            Console.Clear();

            DisplaySubBirds();
            Console.ReadKey();
            Console.Clear();

            DisplayBear();
            Console.ReadKey();
            Console.Clear();



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

            Console.WriteLine("\nPress any key to watch some birds and their behaviour.");
        }

        public static void DisplayBird()
        {
            // Name, Airbourne?, Age, Weight, nrLegs, meatEater?, isWild?, isPrey?
            var bird = new Bird("Måsart", true, 3, 1, 2, true, true, true);
            Console.WriteLine("\t\tB I R D:\n");

            bird.IsHunted();
            Console.WriteLine(" ");

            bird.Eat();
            Console.WriteLine(" ");

            bird.Tame();
            Console.WriteLine(" ");

            bird.Plays();
            Console.WriteLine(" ");

            bird.MakeSound();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            bird.Sleep();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to watch behaviours of 2 other birds.");
            

        }

        public static void DisplaySubBirds()
        {
            // Name, Airbourne?, Age, Weight, nrLegs, meatEater?, isWild?, isPrey, zoo?
            var flamenco = new Flamingo("Flamenco", true, 3, 3, 2, true, true, false, true); // Creates a Flamingo object.
            Console.WriteLine("\t\tF L A M I N G O :\n");

            flamenco.IsHunted();
            Console.WriteLine(" ");

            flamenco.Preen();
            Console.WriteLine(" ");

            flamenco.MakeSound();
            Console.WriteLine(" ");

            flamenco.Eat();
            Console.WriteLine(" ");

            flamenco.Sleep();
            Console.WriteLine(" ");

            // Name, Airbourne?, Age, Weight, nrLegs, meatEater?, isWild?, isPrey, speed
            var roadRunner = new Roadrunner("Roadrunner", true, 3, 4, 2, true, true, false, 32); // Creates a roadrunner.
            Console.WriteLine("\t\tR O A D R U N N E R :\n");

            roadRunner.IsHunted();
            Console.WriteLine(" ");

            roadRunner.Nest();
            Console.WriteLine(" ");

            roadRunner.Eat();
            Console.WriteLine(" ");

            roadRunner.Plays();
            Console.WriteLine(" ");

            roadRunner.Tame();
            Console.WriteLine(" ");

            roadRunner.MakeSound();
            Console.WriteLine(" ");

            Console.WriteLine("Press any key to take a look at the last animal.");

        }

        public static void DisplayBear()
        {
            var bear = new Bear("Benny", 10, 86, 4, true, true, false);
            Console.WriteLine("\t\tB E A R :\n");

            bear.Color();
            Console.WriteLine(" ");

            bear.Eat();
            Console.WriteLine(" ");

            bear.IsHunted();
            Console.WriteLine(" ");

            bear.Tame();
            Console.WriteLine(" ");

            bear.Plays();
            Console.WriteLine(" ");

            bear.MakeSound();
            Console.WriteLine(" ");

            

        }
    }
    
}
