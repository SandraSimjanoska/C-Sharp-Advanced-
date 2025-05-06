//Create a class User that will have 3 properties Id, Name, Age.
//Create a static class UserDatabase that will contain a list of Users (create a couple of users and add them to the list).
//Create a method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.

using Task1;

bool isRunning = true;
while (isRunning)
{
    Console.Clear();

    Console.WriteLine("Search Users by Id, Name, or Age: ");
    string keyword = Console.ReadLine();

    List<User> foundUser = UserDatabase.Search(keyword);
    if (foundUser.Count == 0)
    {
        Console.WriteLine("No users found.");
    }
    else
    {
        Console.WriteLine("Found users:");
        foreach (User user in foundUser)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
        }
    }

    Console.WriteLine("Do you want to search again? (y/n)");
    string answer = Console.ReadLine();

    if (answer.ToLower() != "y")
    {
        isRunning = false;
    }
}


