char start = Console.ReadLine()[0];
char end = Console.ReadLine()[0];
char exclude = Console.ReadLine()[0];
int count = 0;
string combinations = "";

for (char i = start; i <= end; i++)
{
    for (char j = start; j <= end; j++)
    {
        for (char k = start; k <= end; k++)
        {
            if (i != exclude && j != exclude && k != exclude)
            {
                combinations += $"{i}{j}{k} ";
                count++;
            }
        } 
    }
}
Console.WriteLine(combinations.Trim());
Console.WriteLine($"{count}");