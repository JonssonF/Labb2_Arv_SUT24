namespace Labb2_Arv_SUT24
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int AmountLegs { get; set; }
        public bool MeatEater { get; set; }
        public bool IsWild { get; set; }
        public bool Prey { get; set; }

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
            if(MeatEater = true)
            {
                Console.WriteLine($"{Name} is chewing on a good'ol steak.");
            }
            else
            {
                Console.WriteLine($"{Name} is eating a salad.");
            }
        }
        public void Plays()
        {   if(Prey = false)
            {
                Console.WriteLine($"{Name} found a prey to play with.");
            }
            else
            {
                Console.WriteLine($"{Name} found a toy to play with.");
            }
        }
        public virtual void IsHunted()
        {
            if(Prey = true)
            {
            Console.WriteLine($"{Name} runs for cover.");
            }
            else
            {
                Console.WriteLine($"{Name} fights back!");
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }




    }
}
