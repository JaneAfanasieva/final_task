string str = Console.ReadLine();
string[] strs = str.Split(' ');
string[] result = FilterStringsBySize(strs, 3);
PrintArray(strs);
System.Console.Write(" -> ");
PrintArray(result);

string[] FilterStringsBySize(string[] strs, int maxSize)
{
    string[] result = new string[0];

    foreach(string str in strs)
    {
        if(str.Length <= maxSize)
        {
            result = result.Append(str).ToArray();
        }
    }

    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    int lastItemIndex = arr.Length - 1;

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        
        if(i < lastItemIndex)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}