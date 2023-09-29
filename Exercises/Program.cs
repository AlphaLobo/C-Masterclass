using System;
using System.Diagnostics.Tracing;
using System.Threading;

List<string> testWords = new List<string> { "one", "TWO123", "THREE! & ^", "four" };
string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
List<string> GetOnlyUpperCaseWords(List<string> words)
{
    //your code goes here
    List<string> upperWords = new List<string>();
    foreach(string word in words)
    {
        bool addWord = true;
        if(word == word.ToUpper() && !(upperWords.Contains(word.ToUpper())))
        {
            foreach(char letter in word)
            {
                if (!(alphabet.Contains(letter)))
                {
                    addWord = false;
                }
            }
            if (addWord) upperWords.Add(word);
        }
    }

    return upperWords;
}
foreach(string s in GetOnlyUpperCaseWords(testWords))
{
    Console.WriteLine(s);
}

Console.ReadLine();