namespace Labb2_Arv_SUT24.Subclass
{
    public class Roadrunner : Bird
    {

        public int Speed { get; set; } = 0;

        public Roadrunner()
        {

        }

        public Roadrunner(string name, bool isAirbourne, int age, double weight, int amountlegs, bool meatEater, bool isWild, bool prey, int speed)
        : base(name, isAirbourne, age, weight, amountlegs, meatEater, isWild, prey)
        {
            Speed = speed;
        }

        public void Nest() // Displays what a roadrunner uses for building nests.
        {
            Console.WriteLine("The roadrunner collect's some sticks to build a nest for itself.");
        }
        public override void IsHunted()
        {
            if (Speed == 32)
            {
                Console.WriteLine($"{Name} quickly runs away and disappears towards the horizon.");
            }
            else
            {
                Console.WriteLine($"{Name} spots a coyote and quickly paints a tunnel on the mountain wall. Then hides in the bushes.");
            }
        }
        
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} let's out a echoing *Cock-a-doodle-doo!*");
        }

    }
}
