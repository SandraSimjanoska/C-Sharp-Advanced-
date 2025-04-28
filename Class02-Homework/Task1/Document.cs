namespace Task1
{
    public class Document : ISearchable
    {
        public void Search(string word)
        {
           string text = "Today is a sunny day. The sun is shining brightly.";
            if (text.Contains(word))
            {
                Console.WriteLine($"The word '{word}' was found in the document.");
            }
            else
            {
                Console.WriteLine($"The word '{word}' was not found in the document.");
            }
        }
    }
}
