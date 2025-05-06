namespace Exercise.PetStore.Classes
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, string type, int age, bool goodBoy, string favouriteFood) : base(name, type, age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favouriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}, GoodBoy: {GoodBoy}, Favorite Food: {FavoriteFood}");
        }
    }
}
