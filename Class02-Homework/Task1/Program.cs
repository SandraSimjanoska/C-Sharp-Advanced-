//Task 1
//    Write a program to create an interface Searchable with a 
//    method Search(string word) that searches for a given keyword in a text document. 
//    Create two classes Document and WebPage that implement the Searchable 
//    interface and provide their own implementations of the Search() method.

using Task1;
Console.WriteLine("Task 1");
Console.WriteLine("Enter the word to search in the document:");
string word = Console.ReadLine();
Document document = new Document();
document.Search(word);

Console.WriteLine("Enter the word to search in the webpage:");
WebPage webPage = new WebPage();
string word2 = Console.ReadLine();
webPage.Search(word2);
