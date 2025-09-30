// See https://aka.ms/new-console-template for more information
Console.Write("Enter text: ");
string s = Console.ReadLine() ?? "";

(int vowels, int consonants) = CountVowelsAndConsonants(s);

Console.WriteLine($"\nVowels: {vowels}");
Console.WriteLine($"Consonants: {consonants}");

static (int vowels, int consonants) CountVowelsAndConsonants(string s)
{
    int v = 0, c = 0;   // initialize counts
    foreach (char ch in s)
    {
        if (!char.IsLetter(ch)) continue;   // skip non-letters
        char x = char.ToLower(ch);
        if (x is 'a' or 'e' or 'i' or 'o' or 'u') v++;
        else c++; // treat 'y' as consonant by default
    }
    return (v, c);
}
