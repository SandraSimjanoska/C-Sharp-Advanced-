namespace Task1.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public void GetNotification(string msg)
        {
            Console.WriteLine($"{Name}: {msg}");
        }
    }
}
