using Exercise01.TLMS;

List<Dog> dogs = new List<Dog>()
{
    new Dog("Charlie", "Black", 3, Race.Collie), 
    new Dog("Buddy", "Brown", 1, Race.Doberman),
    new Dog("Max", "Olive", 1, Race.Plott),
    new Dog("Archie", "Black", 2, Race.Mutt),
    new Dog("Oscar", "White", 1, Race.Mudi),
    new Dog("Toby", "Maroon", 3, Race.Bulldog), 
    new Dog("Ollie", "Silver", 4, Race.Dalmatian),
    new Dog("Bailey", "White", 4, Race.Pointer),
    new Dog("Frankie", "Gray", 2, Race.Pug),
    new Dog("Jack", "Black", 5, Race.Dalmatian),
    new Dog("Chanel", "Black", 1, Race.Pug), 
    new Dog("Henry", "White", 7, Race.Plott),
    new Dog("Bo", "Maroon", 1, Race.Boxer),
    new Dog("Scout", "Olive", 2, Race.Boxer),
    new Dog("Ellie", "Brown", 6, Race.Doberman),
    new Dog("Hank", "Silver", 2, Race.Collie), 
    new Dog("Shadow", "Silver", 3, Race.Mudi),
    new Dog("Diesel", "Brown", 4, Race.Bulldog),
    new Dog("Abby", "Black", 1, Race.Dalmatian),
    new Dog("Trixie", "White", 8, Race.Pointer), 
};

List<Person> people = new List<Person>()
{
    new Person("Nathanael", "Holt", 20, Job.Choreographer),
    new Person("Rick", "Chapman", 35, Job.Dentist),
    new Person("Oswaldo", "Wilson", 19, Job.Developer),
    new Person("Kody", "Walton", 43, Job.Sculptor),
    new Person("Andreas", "Weeks", 17, Job.Developer),
    new Person("Kayla", "Douglas", 28, Job.Developer),
    new Person("Richie", "Campbell", 19, Job.Waiter),
    new Person("Soren", "Velasquez", 33, Job.Interpreter),
    new Person("August", "Rubio", 21, Job.Developer),
    new Person("Rocky", "Mcgee", 57, Job.Barber),
    new Person("Emerson", "Rollins", 42, Job.Choreographer),
    new Person("Everett", "Parks", 39, Job.Sculptor),
    new Person("Amelia", "Moody", 24, Job.Waiter)
    { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
    new Person("Emilie", "Horn", 16, Job.Waiter),
    new Person("Leroy", "Baker", 44, Job.Interpreter),
    new Person("Nathen", "Higgins", 60, Job.Archivist)
    { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
    new Person("Erin", "Rocha", 37, Job.Developer)
    { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
    new Person("Freddy", "Gordon", 26, Job.Sculptor)
    { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
    new Person("Valeria", "Reynolds", 26, Job.Dentist),
    new Person("Cristofer", "Stanley", 28, Job.Dentist)
    { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
};

Console.WriteLine("1) Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER");
List<string> query1 = people
    .OrderByDescending(p => p.Age)
    .Select(p => p.FirstName)
    .Where(p => p.StartsWith("R"))
    .ToList();

query1.PrintSimple();

List<string> query11 = (
    from person in people
    where person.FirstName.StartsWith("R")
    orderby person.Age descending
    select person.FirstName
).ToList();

//query11.PrintSimple();

Console.WriteLine("2) Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");
List<string> query2 = dogs
    .Where(d => d.Color == "Brown" && d.Age > 3)
    .OrderBy(d => d.Age)
    .Select(d => $"{d.Name} {d.Age}")
    .ToList();

query2.PrintSimple();

List<string> query22 = (
    from person in people
    from dog in person.Dogs
    where dog.Color == "Brown" && dog.Age > 3
    orderby dog.Age ascending
    select dog.Name + " " + dog.Age
).ToList();

//query22.PrintSimple();

Console.WriteLine("3) Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");

List<Person> query3 = people
    .Where(p => p.Dogs.Count > 2)
    .OrderByDescending(p => p.FirstName)
    .ToList();

query3.PrintSimple();

List<Person> query33 = (
    from person in people
    where person.Dogs.Count > 2
    orderby person.FirstName descending
    select person
).ToList();

//query33.PrintSimple();

Console.WriteLine("4) Find and print all Freddy`s dogs names older than 1 year");

List<string> query4 = people
    .Single(p => p.FirstName == "Freddy").Dogs
    .Where(d => d.Age > 1)
    .Select(d => d.Name).ToList();

query4.PrintSimple();

List<string> query44 = (
    from person in people
    where person.FirstName == "Freddy"
    from dog in person.Dogs
    where dog.Age > 1
    select dog.Name
).ToList();

//query44.PrintSimple();

Console.WriteLine("5) Find and print Nathen`s first dog");
Dog query5 = people
   .Single(p => p.FirstName == "Nathen").Dogs
   .First();

Console.WriteLine(query5.Name);

Dog query55 = (
    from person in people
    where person.FirstName == "Nathen"
    from dog in person.Dogs
    select dog
).First();

//Console.WriteLine(query55.Name);

Console.WriteLine("6) Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER");
List<string> dogOwners = new() { "Cristofer", "Freddy", "Erin", "Amelia" };

List<string> query6 = people
    .Where(p => dogOwners.Contains(p.FirstName))
    .SelectMany(p => p.Dogs)
    .Where(d => d.Color.ToLower() == "white")
    .OrderBy(d => d.Name)
    .Select(d => d.Name).ToList();

query6.PrintSimple();

List<string> query66 = (
    from person in people
    where dogOwners.Contains(person.FirstName)
    from dog in person.Dogs
    where dog.Color.ToLower() == "white"
    orderby dog.Name ascending
    select dog.Name
).ToList();

//query66.PrintSimple();