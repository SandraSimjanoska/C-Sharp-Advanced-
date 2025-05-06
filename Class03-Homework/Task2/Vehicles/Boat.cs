namespace Task2.Vehicles
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }

        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
    }
}
