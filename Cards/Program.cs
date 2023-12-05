/*
A S, 10 D, K H, 2 C

5 C, 10 D, king C, K C, Q heart, Q H
*/

using System.Text;

List<Card> cards = new List<Card>();
string[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
foreach (var item in input)
{
    try
    {
            string[] cardInput = item.Split();
            string face = cardInput[0];
            string suit = cardInput[1];
            cards.Add(CreateCard(face, suit));
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine(string.Join(" ", cards));
static Card CreateCard(string face, string suit)
{
    List<string> validFaces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    List<string> validSuits = new List<string>() { "S", "H", "D", "C" };
    Card card = null;

    if (!validFaces.Contains(face) || !validSuits.Contains(suit))
    {
        throw new ArgumentException("Invalid card!");
    }
    card = new Card(face, suit);
            
    return card;
}
public class Card
{
    public Card(string face, string suits)
    {
        Face = face;
        Suit = suits;
    }

    public string Face { get; private set; }
    public string Suit { get; private set; }


    public override string ToString()
    {
        if (Suit == "S")
        {
            Suit = "\u2660";
        }
        if (Suit == "H")
        {
            Suit = "\u2665";
        }
        if (Suit == "D")
        {
            Suit = "\u2666";
        }
        if (Suit == "C")
        {
            Suit = "\u2663";
        }
        return $"[{Face}{Suit}]";
    }
}