//Exceptions and error handling - lab, Task 003
//27.08.2025, 17:25

public class StartUp
{
    static void Main()
    {
        List<Card> cards = new List<Card>();

        string[] cardsData = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

        foreach(var cardData in cardsData)
        {
            string[] parts = cardData.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string face = parts[0];
            string suit = parts[1];

            try
            {
                Card card = new Card(face, suit);

                cards.Add(card);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(string.Join(" ", cards));
    }
}

public class Card
{
    private string[] validFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
    private string[] validSuits = { "S", "H", "D", "C"};

    public string Face { get; private set; }
    public string Suit { get; private set; }

    public Card(string face, string suit)
    {
        ValidateFace(face);
        ValidateSuit(suit);

        Face = face;
        Suit = suit;
    }

    public override string ToString()
    {
        string symbol = "";

        switch(Suit)
        {
            case "S":
                symbol = "\u2660";
                break;
            case "H":
                symbol = "\u2665";
                break;
            case "D":
                symbol = "\u2666";
                break;
            case "C":
                symbol = "\u2663";
                break;
        }

        return $"[{Face}{symbol}]";
    }

    private void ValidateFace(string face)
    {
        if(!validFaces.Contains(face))
        {
            throw new Exception("Invalid card!");
        }
    }

    private void ValidateSuit(string suit)
    {
        if (!validSuits.Contains(suit))
        {
            throw new Exception("Invalid card!");
        }
    }
}