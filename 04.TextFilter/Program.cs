string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
    string censorWord = "".PadLeft(bannedWord.Length, '*');
    while (text.Contains(bannedWord))
    {
        text = text.Replace(bannedWord, censorWord);
    }
}
Console.WriteLine(text);