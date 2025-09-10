using System;
using Cards2;

// loop while there's more input
string? input = Console.ReadLine();
while (input != null)
{


    // Add your code between this comment
    // and the comment below. You can of
    // course add more space between the
    // comments as needed

    // -----------

    //1: Creating a new deck
    Deck deck = new Deck();
    Console.WriteLine("Created a new deck.\n");

    // //2: Shuffle the deck
    // deck.Shuffle();
    // Console.WriteLine("Shuffled the deck.\n");

    // //3: Take the top card and print it
    // Card? topCard = deck.TakeTopCard();
    // if (topCard != null)
    // {
    //     Console.WriteLine($"Top card: {topCard.Rank} of {topCard.Suit}\n");
    // }

    //4: Attempt to modify the card’s rank (uncomment to see error)
    // topCard.Rank = Rank.Two;
    /*
     * If you uncomment the above, you get:
     * error CS0200: Property or indexer 'Card.Rank' cannot be assigned to -- it is read only
     */
    // Console.WriteLine("Step 4: Cannot modify the rank of a Card (compile-time error).\n");

    //5: Print all the cards left in the deck
    Console.WriteLine("Remaining cards in the deck:\n");
    deck.Print();

    // Exercise 2 code

    // Extra: check if the deck is empty
    Console.WriteLine($"\nIs the deck Empty? {deck.Empty}");

    // -----------

    // Declare a new deck variable and create a deck object
    // DON'T SHUFFLE THE DECK
    deck = new Deck();

    // Create hands for 4 players
    List<Card> player1 = new List<Card>();
    List<Card> player2 = new List<Card>();
    List<Card> player3 = new List<Card>();
    List<Card> player4 = new List<Card>();

    // Deal 2 cards each to 4 players (deal properly, round-robin)
    for (int round = 0; round < 2; round++)
    {
        player1.Add(deck.TakeTopCard()!);
        player2.Add(deck.TakeTopCard()!);
        player3.Add(deck.TakeTopCard()!);
        player4.Add(deck.TakeTopCard()!);
    }

    // Deal 1 more card to players 2 and 3
    player2.Add(deck.TakeTopCard()!);
    player3.Add(deck.TakeTopCard()!);

    //Flip feature 
    foreach (Card c in player1) { c.FlipOver(); }
    foreach (Card c in player2) { c.FlipOver(); }
    foreach (Card c in player3) { c.FlipOver(); }
    foreach (Card c in player4) { c.FlipOver(); }
    Console.WriteLine("Each players cards have been flipped.\n");


    // Print the cards for Player 1
    Console.WriteLine("\nPlayer 1:");
    foreach (var c in player1) Console.WriteLine($"{c.Rank} of {c.Suit}");

    // Print the cards for Player 2
    Console.WriteLine("\nPlayer 2:");
    foreach (var c in player2) Console.WriteLine($"{c.Rank} of {c.Suit}");

    // Print the cards for Player 3
    Console.WriteLine("\nPlayer 3:");
    foreach (var c in player3) Console.WriteLine($"{c.Rank} of {c.Suit}");

    // Print the cards for Player 4
    Console.WriteLine("\nPlayer 4:");
    foreach (var c in player4) Console.WriteLine($"{c.Rank} of {c.Suit}");
    
    input = Console.ReadLine();
}