namespace Labb2_Arv_SUT24.Superclass
{
    public class Rabbit : Animal
    {
        public string Gender { get; set; } = "unknown";

        public Rabbit()
        {
                
        }

        public Rabbit(string name, string gender, int age, double weight, int amountlegs, bool meatEater, bool isWild, bool prey) 
        : base(name, age, weight, amountlegs, meatEater, isWild, prey)
        {
            Gender = gender;
        }

        public void Mate()
        {
            Random rng = new Random();
            int rnd = rng.Next(2, 16);
            if (Gender == "Male")
            {
                Console.WriteLine($"Looks like {Name} was castrated.");
            }
            else
            {
                Console.WriteLine($"It appears that {Name} had a litter of {rnd} babies!");
            }
        }
        public override void MakeSound()
        {
            base.MakeSound();
            if (Prey == true)
            {
                Console.WriteLine("hissing sound.");
            }
            else
            {
                Console.WriteLine("purring sound.");
            }

        }
        public override void IsHunted()
        {
            
            if(Gender == "Male")
            {
            Console.WriteLine($"{Name} runs for his life then hides in his burrow.");
            }
            else
            {
            Console.WriteLine($"{Name} were already asleep, in her burrow.");
            }

        }
    }
}
