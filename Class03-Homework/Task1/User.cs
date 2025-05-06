using System;
using System.Collections.Generic;
namespace Task1
{
    public class User
    {
        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
