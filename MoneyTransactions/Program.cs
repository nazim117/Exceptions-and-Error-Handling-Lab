/*
1-45.67,2-3256.09,3-97.34
Deposit 1 50
Withdraw 3 100
End
1473653-97.34,44643345-2347.90
Withdraw 1473653 150.50
Deposit 44643345 200
Block 1473653 30
Deposit 1 30
End 
*/

Dictionary<int, decimal> bankAccount = new Dictionary<int, decimal>();

string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

foreach (var pair in input)
{
    string[] keyValue = pair.Split("-");
    int key = int.Parse(keyValue[0]);
    decimal value = decimal.Parse(keyValue[1]);

    bankAccount[key] = value;
}

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();

    try
    {
        int accNumber = int.Parse(arguments[1]);
        decimal money = decimal.Parse(arguments[2]);
        if (arguments[0] == "Deposit")
        {
            bankAccount = Deposit(bankAccount, accNumber, money);
        }
        else if (arguments[0]== "Withdraw")
        {
            bankAccount = Withdraw(bankAccount, accNumber, money);
        }
        else
        {
            throw new ArgumentException("Invalid command!");
        }
        Console.WriteLine($"Account {accNumber} has new balance: {bankAccount[accNumber]}");
    }
    catch (ArgumentException ex) 
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Enter another command");
    }
}

Dictionary<int, decimal> Withdraw(Dictionary<int, decimal> bankAccount, int accNumber, decimal money)
{
    if (bankAccount[accNumber] < money)
    {
        throw new ArgumentException("Insufficient balance!");
    }
    bankAccount[accNumber] -= money;
    return bankAccount;
}

Dictionary<int, decimal> Deposit(Dictionary<int, decimal> bankAccount, int accNumber, decimal money)
{
    if (!bankAccount.ContainsKey(accNumber))
    {
        throw new ArgumentException("Invalid account!");
    }
    bankAccount[accNumber] += money;
    return bankAccount;
}