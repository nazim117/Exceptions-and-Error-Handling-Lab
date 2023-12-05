/*
1 2 3 4 5
Replace 1 9
Replace 6 3
Show 3
Show peter
Show 6

1 2 3 4 5
Replace 3 9
Print 1 4
Print -3 12
Print 1 5
Show 3
Show 12.3

*/

using System.Collections.Generic;

List<int> input =
    Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int exceptionCounter = 0;
while (exceptionCounter != 3)
{
    string[] command = Console.ReadLine().Split();
    try
    {
        switch (command[0])
        {
            case "Replace":
                int index1 = int.Parse(command[1]); 
                int element = int.Parse(command[2]); 
                input = Replace(input, index1, element);
                break;
                
            case "Show":
                int index = int.Parse(command[1]); 
                if (index > input.Count || index < 0)
                {
                    throw new IndexOutOfRangeException("The index does not exist!");
                }
                Console.WriteLine(input[index]);
                break;
            case "Print":
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                Print(input,startIndex,endIndex);
                break;
        }
    }
    catch (FormatException)
    {
        exceptionCounter++;
        Console.WriteLine("The variable is not in the correct format!");
    }
    catch (IndexOutOfRangeException ex)
    {
        exceptionCounter++;
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine(string.Join(", ", input));

void Print(List<int> input, int startIndex, int endIndex)
{
    if (startIndex > input.Count-1 || startIndex < 0 || endIndex > input.Count-1 || endIndex < 0)
    {
        throw new IndexOutOfRangeException("The index does not exist!");
    }
    List<int> printList = new List<int>();
    for (int i = startIndex; i <= endIndex; i++)
    {
        printList.Add(input[i]);
    }
    Console.WriteLine(string.Join(", ", printList));
}

List<int> Replace(List<int>list, int index1, int element)
{
    if (index1 > list.Count || index1 < 0)
    {
        throw new IndexOutOfRangeException("The index does not exist!");
    }
    list[index1] = element;
    return list;
}