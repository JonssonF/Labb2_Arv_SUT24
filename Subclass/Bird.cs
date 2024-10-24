namespace Labb2_Arv_SUT24.Subclass
{
    internal class Bird : Animal
    {

        public string IsAirbourne { get; set; } = "unkown";

        public Bird(string name = "unknown", string isAirbourne = "unknown", int age = 0, double weight = 0, int amountlegs = 0, bool meatEater = false, bool isWild = false, bool prey = true)
        : base(name, age, weight, amountlegs, meatEater, isWild, prey)
        {
            IsAirbourne = isAirbourne;

        }

        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
