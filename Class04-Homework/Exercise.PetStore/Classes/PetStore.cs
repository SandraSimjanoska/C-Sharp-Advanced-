namespace Exercise.PetStore.Classes
{
    public class PetStore<T> where T : Pet
    {
        public List<T> pets = new List<T>();
        public void PrintPets()
        {
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void AddPet(T pet)
        {
            pets.Add(pet);
        }

        public void BuyPet(string name)
        {
            T pet = pets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());

            if (pet != null)
            {
                pets.Remove(pet);
                Console.WriteLine($"You bought a {pet.Type} named {pet.Name}!");
            }
            else
            {
                Console.WriteLine($"Sorry, no pet named {name} was found.");
            }
        }
    }
}
