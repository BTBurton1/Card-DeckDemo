using Cards2;

class Program
{
    static void Main()
    {
        //1: Creating a new deck
        Deck deck = new Deck();
        Console.WriteLine("Created a new deck.\n");

        //2: Shuffle the deck

        deck.Shuffle();
        Console.WriteLine("Shuffled the deck.\n");

        //3: Takes the top card and print it
        Card? topCard = deck.TakeTopCard();
        if (topCard != null)
        {
            Console.WriteLine($"Top card: {topCard.Rank} of {topCard.Suit}\n");
        }

        // 4: Attempt to modify the card’s rank (uncomment to see error)
        // This line does not compile — it demonstrates immutability.
        // topCard.Rank = Rank.Two;

        /*
         * If you uncomment, you get the output:
         * error CS0200: Property or indexer 'Card.Rank' cannot be assigned to -- it is read only
         */

        Console.WriteLine("Step 4: Cannot modify the rank of a Card (compile-time error).\n");

        // 5: Prints all the cards left in the deck
        Console.WriteLine("Remaining cards in the deck:\n");
        deck.Print();

        // Extra: check if the deck is empty
        Console.WriteLine($"\nIs the deck Empty? {deck.Empty}");
    }
}