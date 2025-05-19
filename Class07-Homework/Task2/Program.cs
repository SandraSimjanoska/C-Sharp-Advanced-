using Task2;

Console.WriteLine("Online classes");
Console.WriteLine("=====================================");

User.AlertEvent += User.SendAlert; 

Console.WriteLine("User Login");
Console.WriteLine("Enter your name:");
string username = Console.ReadLine();

User user = new User();
user.LogIn(username);

User.AlertEvent -= User.SendAlert;