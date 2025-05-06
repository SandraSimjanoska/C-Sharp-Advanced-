//Create class PrintInConsole that will have multiple methods to print in console. Print(), PrintCollection().
//Make this methods to be valid for more that one type and reuse the implenetation (hint: make them generic);
using Task1;

PrintInConsole print = new PrintInConsole();

print.Print("Hello Slave!");
print.Print(123);

Console.WriteLine("Ingredients for cake: ");
List<string> recipeItem = new List<string>();
recipeItem.Add("Flour");
recipeItem.Add("Milk");
recipeItem.Add("Sugar");
recipeItem.Add("Eggs");
recipeItem.Add("Chocolate");
print.PrintCollection(recipeItem);


Console.WriteLine("__________________________");
int[] numbers = new int[5] { 1, 2, 3, 4 , 5 };
print.PrintCollection(numbers);

Console.WriteLine("__________________________");
List<int> numbers2 = new List<int>();
numbers2.Add(100);
numbers2.Add(200);
numbers2.Add(300);
print.PrintCollection(numbers2);