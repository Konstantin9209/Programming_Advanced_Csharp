string word = Console.ReadLine();

while (word != "end")
{
    string reversedWord = "";

    for (int i = word.Length - 1; i >= 0; i -= 1)
    {
        reversedWord += word[i];

    }
    Console.WriteLine($"{word} = {reversedWord}");
    word = Console.ReadLine();
}