// See https://aka.ms/new-console-template for more information
Console.Write("Enter text: ");
string s = Console.ReadLine() ?? "";

Console.WriteLine("\nResult:");
Console.WriteLine(CapitalizeSentences(s));

static string CapitalizeSentences(string s)
{
    if (string.IsNullOrEmpty(s)) return s;  // nothing to do with empty string

    char[] a = s.ToCharArray();
    bool needCap = true; // treat start as sentence start

    // iterate through characters
    for (int i = 0; i < a.Length; i++)
    {
        // capitalize letter if needed
        if (needCap && char.IsLetter(a[i]))     
        {
            a[i] = char.ToUpper(a[i]);
            needCap = false;    // reset flag
        }

        if (a[i] is '.' or '!' or '?')
            needCap = true; // next letter after boundary gets capped
    }
    return new string(a);
}