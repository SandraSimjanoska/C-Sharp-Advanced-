namespace Task2
{
    public class User
    {
        public string Name { get; set; }

        public delegate void AlertDelegate(string username);
        public static event AlertDelegate AlertEvent;

        public static void SendAlert(string username)
        {
            Console.WriteLine($"{username} Users Found.");
            Console.WriteLine("Sending Email to Administration...");
            Console.WriteLine("Email Sent.");
            Console.WriteLine("Warning Alarm Started.");
            Console.WriteLine("Logging out.");
        }

        public List<string> BannedUsers = new() { "Bob", "Jill", "Alice"};

        public void LogIn(string username)
        {
            if (BannedUsers.Contains(username))
            {
                AlertEvent?.Invoke(username);
            }
            else
            {
                Console.WriteLine($"Welcome {username}.");
            }
        }
    }
}
