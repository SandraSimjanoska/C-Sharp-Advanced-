using Task1.Entities;

Console.WriteLine("Teacher Notificator app");
Teacher Martin = new () { Name = "Martin", Age = 30, Email = "martin.pano@gmail.com", Subject = "C#"};

Student sandra = new () { Name = "Sandra", Age = 27, Email = "sandra.simjanoska@live.com", Subject = "C#" };
Student angel = new () { Name = "Angel", Age = 27, Email = "angel.ivanovski@gmail.com", Subject = "C#" };
Student ivana = new () { Name = "Ivana", Age = 30, Email = "ivana.nikolovska@gmail.com", Subject = "C#" };

Console.WriteLine("=====================================");
Martin.Subscribe(sandra);
Martin.Subscribe(angel);
Martin.Subscribe(ivana);

Console.WriteLine("=====================================");
Martin.SendNotification();

Console.WriteLine("=====================================");
Martin.Unsubscribe(angel);
Martin.Unsubscribe(sandra);

Console.WriteLine("=====================================");
Martin.SendNotification();

