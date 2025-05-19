namespace Task1.Entities
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public delegate void NotificationDelegate(string msg);
        public event NotificationDelegate NotifyEvent;

        public void Subscribe(Student student)
        {
            NotifyEvent += student.GetNotification;
            Console.WriteLine($"{student.Name} subscribed to Teacher {Name}'s notifications.");
        }

        public void Unsubscribe(Student student)
        {
            NotifyEvent -= student.GetNotification;
            Console.WriteLine($"{student.Name} unsubscribed from Teacher {Name}'s notifications.");
        }

        public void SendNotification()
        {
            Console.WriteLine("Sending notifications to all students...");
            NotifyEvent?.Invoke($"Notification from Teacher {Name} : Class for {Subject} will start at 10 AM.");
        }
    }
}