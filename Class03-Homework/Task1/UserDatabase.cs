namespace Task1
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();
        static UserDatabase()
        {
            Users.Add(new User(1, "Sandra", 27));
            Users.Add(new User(2, "Angel", 27));
            Users.Add(new User(3, "Marija", 50));
            Users.Add(new User(4, "Boba", 43));
            Users.Add(new User(5, "Bob", 45));
            Users.Add(new User(6, "Miki", 30));
            Users.Add(new User(7, "Riki", 10));
            Users.Add(new User(8, "Ljubomir", 90));
            Users.Add(new User(9, "Trpa", 72));
        }

        public static List<User> Search(string keyword)
        {
            List<User> result = new List<User>();

            bool isNumber = int.TryParse(keyword, out int number);

            foreach (User user in Users)
            {
                if (user.Name.ToLower().Contains(keyword.ToLower()))
                {
                    result.Add(user);
                }
                else if (isNumber && user.Id == number || user.Age == number)
                {
                    result.Add(user);
                }
            }
            return result;
        }
    }
}

