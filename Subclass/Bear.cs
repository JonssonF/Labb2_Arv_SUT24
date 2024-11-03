namespace Labb2_Arv_SUT24
{
    internal class Bear : Animal
    {
       
        
        public string FurColor { get; set; }
        private static Random random = new Random();
        public Bear()
        {

        }

        public Bear(string name, int age, double weight, int amountlegs, bool meatEater, bool isWild, bool prey)
        : base(name, age, weight, amountlegs, meatEater, isWild, prey)
        {
            FurColor = furColor();
        }
        private string furColor() // Random fur color, instead of a default value.
        {
            string[] colors = { "black", "white", "grey", "brown" };
            int index = random.Next(colors.Length);
            return colors[index];
        }
        
            
            
        public void Color() // Method to check the bear color of the fur.
        {
            int idle;
            idle = DateTime.Now.Month;

            if (FurColor == "white")
            {
                Console.WriteLine($"{Name} lives on the arctic, and you guessed it, the fur is {FurColor}.");
            }
            else if (idle >= 10 || idle <= 4) // Condition to check the color, wont be avaible if the bear is in hibernation.
            {
                Console.WriteLine($"{Name} is in hibernation, we will have to wait.");
            }
            else
            {
                Console.WriteLine($"The bear named {Name} have a {FurColor} colored fur.");
            }
        }

        public override void Tame()
        {
            Console.WriteLine($"Even tho {Name} seems nice, i would never trust a bear.");
        }
        public override void IsHunted()
        {
            base.IsHunted();
        }
        public override void MakeSound()
        {
            int idle;
            idle = DateTime.Now.Month;

            if (idle >= 10 || idle <= 4) // Hibernation = Asleep.
            {
                Console.WriteLine("**Intense snooring**");
                Console.WriteLine("ZZZzzzZzZZzzzZZzz. . .");
            }
            else // Not in hibernation = roar.
            {
                Console.WriteLine($"{Name} let's out a fierce roar!");
            }
        }

    }
}
