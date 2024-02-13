string[] words = Console.ReadLine().Split();

string output = "";

for  (int i = 0; i < words.Length; i++)
{
    string currentWord = words[i];
    for (int j = 0; j < currentWord.Length; j += 1)
    {
        output += currentWord[j];
    }
}

Console.WriteLine(output);