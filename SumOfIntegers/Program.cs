/*
2147483649 2 3.4 5 invalid 24 -4

9876 string 10 -2147483649 -8 3 4.86555 8
*/

string input = Console.ReadLine();

string[] elements = input.Split(' ');

int sum = 0;

foreach (string element in elements)
{
    try
    {
        int num = int.Parse(element);
        sum += num;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{element}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{element}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
    }
}

Console.WriteLine($"The total sum of all integers is: {sum}");