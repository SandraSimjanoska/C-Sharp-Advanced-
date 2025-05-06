namespace Task2.Vehicles
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and i drive on 4 wheels :)");
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
