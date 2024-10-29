namespace Labb2_Arv_SUT24.Subclass
{
    public class Bird : Animal
    {

        public bool IsAirbourne { get; set; } = false;

        public Bird()
        {

        }

        public Bird(string name, bool isAirbourne, int age, double weight, int amountlegs, bool meatEater, bool isWild, bool prey)
        : base(name, age, weight, amountlegs, meatEater, isWild, prey)
        {
            IsAirbourne = isAirbourne;

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.Write("screech!");
        }

        public override void IsHunted()
        {
            if(IsAirbourne == true)
            {
                Console.WriteLine($"{Name} detects a threat and lift off to the sky!");
            }
            else
            {
                Console.WriteLine($"{Name} runs as fast as he cans but doesnt stand a chance to the fierce predator.");
            }
        }
    }
}
