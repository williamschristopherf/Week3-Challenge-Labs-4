string example = "ABFCACDB";
string sub1 = "AB";
string sub2 = "CD";

Console.WriteLine($"Initial string: {example}");
static string FindSubString(string example, string sub1, string sub2)
{
    do
    {
        //uses 2 .replace together and replaces with value"" which is empty 
        string updated = example.Replace(sub1, "").Replace(sub2, "");
        //checks for changes. If not breaks loop and outputs example.
        if (updated == example)
        {
            break;
        }
        example = updated;

    }
    while (true);

    return example;
}


Console.WriteLine($"The final substring is {FindSubString(example, sub1, sub2)}.");
Console.WriteLine($"The resulting length of the string is {FindSubString(example, sub1, sub2).Length}.");