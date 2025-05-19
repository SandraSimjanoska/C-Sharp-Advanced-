namespace Task1
{
    public static class PrintHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine("Printing...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }


        public static void PrintEntities<T>(this List<T> list) where T : class
        {
            Console.WriteLine($"Printing {list[0].GetType().Name}s...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                if (item is Car car)
                {
                    Console.WriteLine(car.Model);
                }
            }
            Console.WriteLine("------------------------------");
        }
    }
}
