string word = Console.ReadLine();

while (word != "end")
{
    string reveresedWord = "";
    for (int i = word.Length - 1; i >= 0; i -= 1)
    {
        reveresedWord += word[i];
    }
    Console.WriteLine($"{word} = {reveresedWord}");

    word = Console.ReadLine();
}