using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class WebPage : ISearchable
    {
        public void Search(string word)
        {
            string text = "Welcome to the world of programming. Programming is fun and exciting.";
            if (text.Contains(word))
            {
                Console.WriteLine($"The word '{word}' was found in the webpage.");
            }
            else
            {
                Console.WriteLine($"The word '{word}' was not found in the webpage.");
            }
        }
    }
}
