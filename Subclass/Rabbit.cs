namespace Labb2_Arv_SUT24.Superclass
{
    public class Rabbit : Animal
    {
        public string Gender { get; set; } = "unknown";
        public bool Male { get; private set; }

        public Rabbit(string name = "unknown", string gender = "unknown", int age = 0, double weight = 0, int amountlegs = 0, bool meatEater = false, bool isWild = false, bool prey = true) 
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
