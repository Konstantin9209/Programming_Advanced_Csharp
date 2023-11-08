//string fruits = "banana, apple";
//Console.WriteLine(fruits.IndexOf("apple"));

string wordToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(wordToRemove))
{
    text = text.Replace(wordToRemove, "");

}
Console.WriteLine(text);
