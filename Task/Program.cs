string[] array = {"1234", "1567","-2", "computer science"};
string[] result = ArrayCount(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] ArrayCount(string[] array, int n) 
{
    string[] output = new string[CountIndex(array, n)];
    for(int i = 0, j = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= n) 
        {
            output[j] = array[i];
            j++;
        }
    }
    return output;
}

int CountIndex(string[] input, int n) 
{
    int count = 0;
    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}

