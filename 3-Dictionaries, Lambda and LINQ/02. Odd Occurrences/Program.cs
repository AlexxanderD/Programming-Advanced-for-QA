string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> wordsCount = new Dictionary<string, int>();

foreach (string word in words)
{
    string caseInsensitiveWord = word.ToLower();
    if (wordsCount.ContainsKey(caseInsensitiveWord))
    {
       
        wordsCount[caseInsensitiveWord]++;
    }
    else 
    { 
        wordsCount[caseInsensitiveWord] = 1;
    }
}
foreach (KeyValuePair<string, int> pair in wordsCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}