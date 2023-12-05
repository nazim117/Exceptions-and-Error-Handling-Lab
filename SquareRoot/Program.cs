int number = 0;
try
{
    number = int.Parse(Console.ReadLine());
    if (number < 0)
    {
        throw new FormatException("Invalid number.");
    }
    Console.WriteLine(Math.Sqrt(number));
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Goodbye.");
}