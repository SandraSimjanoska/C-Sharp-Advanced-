namespace Task2.Vehicles
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
