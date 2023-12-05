/*
2
3
4
5
6
7
8
9
10
11

1
2
1
3
p
4
5
6
7
8
9
10
11

*/

List<int> numbers = new List<int>();
int start = 1;
int end = 100;


while (numbers.Count < 10)
{
    try
    {
        int number = ReadNumber(start, end);
        if (numbers.Count > 0 && number <= numbers[numbers.Count - 1])
        {
            continue;
        }
        start++;
        numbers.Add(number);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(", ", numbers));

    static int ReadNumber(int start, int end)
    {
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }
        }
        catch (FormatException)
        {
            throw new FormatException("Invalid Number!");
        }

        return number;
    }