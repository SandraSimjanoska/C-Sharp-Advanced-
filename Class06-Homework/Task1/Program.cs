using Task1;
//1
Console.WriteLine("1");
Console.WriteLine("Filter all cars that have origin from Europe and print them in console.");
List<Car> carsFromEurope = CarsData.Cars
                           .Where(x => x.Origin  == "Europe").ToList();
carsFromEurope.PrintEntities();

//2
Console.WriteLine("2");
Console.WriteLine("Filter all cars that have more that 6 Cylinders not including 6 after that Filter all cars that have exactly" +
" 4 Cylinders and have HorsePower more then 110.0. Join them in one result and print them in console.");

//List<Car> carsWithMoreThan6Cylinders = CarsData.Cars
//                                      .Where(x => x.Cylinders > 6)
//                                      .ToList();

//List<Car> carsWith4CylindersAnd110HP = CarsData.Cars
//                                      .Where(x => x.Cylinders == 4 && x.HorsePower > 110.0)
//                                      .ToList();

//List<Car> joinedCars = carsWithMoreThan6Cylinders
//                      .Concat(carsWith4CylindersAnd110HP)
//                      .ToList();
//joinedCars.PrintEntities();
List<Car> joinedCars = CarsData.Cars
                      .Where(x => x.Cylinders > 6 || (x.Cylinders == 4 && x.HorsePower > 110.0))
                      .ToList();
joinedCars.PrintEntities();


//3
Console.WriteLine("3");
Console.WriteLine("Count all cars based on their Origin and print the result in console. Example outpur \"US 10 models\\n Eu 15 Models\";");

var carCountByOrigin = CarsData.Cars
                      .GroupBy(x => x.Origin)
                      .Select(x => (Origin: x.Key, Count: x.Count()));

foreach (var originGroup in carCountByOrigin)
{
    Console.WriteLine($"{originGroup.Origin} {originGroup.Count} models");
}

//4
Console.WriteLine("4");
Console.WriteLine("Filter all cars that have more then 200 HorsePower and Find out how much is the lowest," +
" highes and average Miles per galon and print them in console;");
List<Car> carsWithMoreThan200HorsePower = CarsData.Cars
                                          .Where(x => x.HorsePower > 200)
                                          .ToList();
double lowestMilesPerGalon = carsWithMoreThan200HorsePower.Min(x => x.MilesPerGalon);
double highestMilesPerGalon = carsWithMoreThan200HorsePower.Max(x => x.MilesPerGalon);
double averageMilesPerGalon = carsWithMoreThan200HorsePower.Average(x => x.MilesPerGalon);

Console.WriteLine($"Lowest Miles per Galon: {lowestMilesPerGalon}");
Console.WriteLine($"Highest Miles per Galon: {highestMilesPerGalon}");
Console.WriteLine($"Average Miles per Galon: {averageMilesPerGalon}");

//5
Console.WriteLine("5");
Console.WriteLine("Find the top 3 fastest accelerating cars:");
List<Car> fastestAcceleratingCars = CarsData.Cars
                                   .OrderBy(x => x.AccelerationTime)
                                   .Take(3)
                                   .ToList();
fastestAcceleratingCars.PrintEntities();

//6
Console.WriteLine("6");
Console.WriteLine("Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list." +
    " Print the model of each of these top 3 cars.");

List<Car> top3FastestCars = CarsData.Cars
                           .OrderBy(x => x.AccelerationTime)
                           .Take(3)
                           .ToList();
foreach (var car in top3FastestCars)
{
    Console.WriteLine(car.Model);
}

//7 
Console.WriteLine("7");
Console.WriteLine("Calculate the total weight of cars with more than 6 cylinders:");
double totalWeight = CarsData.Cars
                    .Where(x => x.Cylinders > 6)
                    .Sum(x => x.Weight);
Console.WriteLine($"Total weight of cars with more than 6 cylinders: {totalWeight}");

//8
Console.WriteLine("8");
Console.WriteLine("Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight.");

double totalWeightOfCarsWithMoreThan6Cylinders = CarsData.Cars
                                                .Where(x => x.Cylinders > 6)
                                                .Sum(x => x.Weight);
Console.WriteLine($"Total weight of cars with more than 6 cylinders: {totalWeightOfCarsWithMoreThan6Cylinders}");

//9
Console.WriteLine("9");
Console.WriteLine("Find the average MilesPerGalon for cars with even number of cylinders:");
double averageMilesPerGalonForEvenCylinders = CarsData.Cars
                                              .Where(x => x.Cylinders % 2 == 0)
                                              .Average(x => x.MilesPerGalon);
Console.WriteLine($"Average MilesPerGalon for cars with even number of cylinders: {averageMilesPerGalonForEvenCylinders}");

//10
Console.WriteLine("10");
Console.WriteLine("Filter cars that have an even number of cylinders. Calculate the average MilesPerGalon for these cars. " +
    "Print the average MilesPerGalon.");
double averageMilesPerGalonForEvenCylinders2 = CarsData.Cars
                                              .Where(x => x.Cylinders % 2 == 0)
                                              .Average(x => x.MilesPerGalon);
Console.WriteLine($"Average MilesPerGalon for cars with even number of cylinders: {averageMilesPerGalonForEvenCylinders2}");


