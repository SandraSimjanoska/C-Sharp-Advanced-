namespace Task1
{
    public class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public void PrintCollection<T>(IEnumerable<T> items)
        {
            int count = 1;
            foreach (T item in items)
            {
                Console.WriteLine($"Item {count}: {item}");
                count++;
            }
        }
    }
}
