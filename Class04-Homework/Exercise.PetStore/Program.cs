//Create 4 classes:
//➢ Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
//➢ Dog(from Pet ) with GoodBoy and FavoriteFood
//➢ Cat( from Pet ) with Lazy and LivesLeft
//➢ Fish( from Pet ) with color, size
//➢ Create a PetStore generic class with :
//➢ Generic list of pets - Dogs, Cats or Fish depending on what is passed as T
//➢ Generic method printsPets() - Prints Dogs, Cats or Fish depending on what is
//passed as T
//➢ BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name,
//removes it from the list and gives a success message.If there is no pet by that
//name, inform the customer
//➢ Create a Dog, Cat and fish store with 2 pets each
//➢ Buy a dog and a cat from the Dog and Cat store
//➢ Call PrintPets() method on all stores

using Exercise.PetStore.Classes;

Console.WriteLine("Welcome to the Pet Store!");

PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.AddPet(new Dog("Aron", "Dog", 4, true, "Bones"));
dogStore.AddPet(new Dog("Sharko", "Dog", 2, true, "Chicken"));

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.AddPet(new Cat("Mici","Cat", 3, true, 9));
catStore.AddPet(new Cat("Amon","Cat", 18, false, 9));

PetStore<Fish> fishStore = new PetStore<Fish>();
fishStore.AddPet(new Fish("Nemo", "Fish", 1, "Orange and White", "Small"));
fishStore.AddPet(new Fish("Dory", "Fish", 2, "Blue", "Medium"));

dogStore.BuyPet("Aron");
catStore.BuyPet("Amon");

Console.WriteLine("----------------------");
Console.WriteLine("Remaining Dogs:");
dogStore.PrintPets();

Console.WriteLine("----------------------");
Console.WriteLine("Remaining Cats:");
catStore.PrintPets();

Console.WriteLine("----------------------");
Console.WriteLine("Available Fish:");
fishStore.PrintPets();
