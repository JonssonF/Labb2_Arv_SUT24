using Labb2_Arv_SUT24.Subclass;
using System.Xml.Linq;

namespace Labb2_Arv_SUT24
{
    public class Flamingo : Bird
    {
        public bool Zoo { get; set; } = true;

        public Flamingo()
        {
                
        }

        public Flamingo(string name, bool isAirbourne, int age, double weight, int amountlegs, bool meatEater, bool isWild, bool prey, bool zoo)
        : base(name, isAirbourne, age, weight, amountlegs, meatEater, isWild, prey)
        {
            Zoo = zoo;          
        }
        
        public override void IsHunted()
        {
            if(Zoo == true)
            {
                Console.WriteLine($"Looks like {Name} belongs to a zoo.");
            }
            else
            {
                Console.WriteLine($"{Name} does not fear alot of predators, Flamingoes biggest threat is loss of natural habitat.");
            }
        }
        public void Preen()
        {
            Console.WriteLine($"{Name} starts distributing oil from a gland at the base of their tail to their feathers for waterproofing. \n(True story) ");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a nasal honk!");

        }
    }
}
