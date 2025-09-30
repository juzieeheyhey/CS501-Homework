// See https://aka.ms/new-console-template for more information
Console.Write("Enter text: ");
string s = Console.ReadLine() ?? "";

if (s.Length == 0)
{
    Console.WriteLine("\nNo characters to analyze.");
    return;
}

var counts = new Dictionary<char, int>();   // initialize character counts
// track best char as we go and how many times it occurred
char bestChar = '\0';
int bestCount = 0;

foreach (char raw in s)
{
    if (char.IsWhiteSpace(raw)) continue;        // skip spaces
    char c = char.ToLower(raw);                  // case insensitive

    if (counts.TryGetValue(c, out int cur))     // increment count if exists
        counts[c] = cur + 1;
    else
        counts[c] = 1;

    if (counts[c] > bestCount || (counts[c] == bestCount && c < bestChar))  // if count is best so far or tie with smaller char code
    {
        bestChar = c;        // tie-breaker: smaller char code
        bestCount = counts[c];
    }
}

if (bestCount == 0)
    Console.WriteLine("\nNo characters to analyze.");
else
    Console.WriteLine($"\nMost frequent character: '{bestChar}' occurred {bestCount} times.");