namespace Labb2_Arv_SUT24
{
    public class Animal
    {
        public string Name { get; set; } = "unknown";
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public int AmountLegs { get; set; } = 0;
        public bool MeatEater { get; set; } = false;
        public bool IsWild { get; set; } = false;
        public bool Prey { get; set; } = false;

        public Animal()
        {

        }


        public Animal(string name, int age, double weight, int amountlegs, bool meatEater, bool isWild, bool prey)
        {
            Name = name;
            Age = age;
            Weight = weight;
            AmountLegs = amountlegs;
            MeatEater = meatEater;
            IsWild = isWild;
            Prey = prey;
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public void Eat()
        {
            if(MeatEater == true)
            {
                Console.WriteLine($"{Name} is chewing on a good'ol steak.");
            }
            else
            {
                Console.WriteLine($"{Name} is eating a salad.");
            }
        }
        public virtual void Tame()
        
        {
            if (IsWild == true && MeatEater == true)
            {
                Console.WriteLine($"I would be careful aproaching this one. {Name} can bite.");
            }
            else if (IsWild == true && MeatEater == false)
            {
                Console.WriteLine($"Even if {Name} were found in the wild," +
                    $" {Name} is trained to be a pet.");
            }
            else
            {
                Console.WriteLine($"You have nothing to worry about, u can pet {Name}.");
            }
        }
        public void Plays()
        {   
            if (Weight > 50)
            {
                Console.WriteLine($"{Name} is too tired to play.");
            }
            else if(Prey == false && MeatEater == true)
            {
                Console.WriteLine($"{Name} found a prey to play with. . . Only to become a snack after.");
            }
            else if (Prey == false && MeatEater == false)
            {
                Console.WriteLine($"{Name} found a prey to play with. Just for fun.");
            }
            else
            {
                Console.WriteLine($"{Name} found a toy to play with.");
            }
        }
        public virtual void IsHunted()
        {
            if(Prey == true)
            {
            Console.WriteLine($"{Name} runs for cover.");
            }
            else
            {
                Console.WriteLine($"{Name} fights back!");
            }
        }

        public virtual void MakeSound()
        {   if(Prey == true)
            {
            Console.Write($"{Name} makes a terrifying, ");
            }
            else
            {
                Console.Write($"{Name} makes a loud, ");
            }
        }




    }
}
