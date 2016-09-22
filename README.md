# GameHomework2

HW 2: OOP and Text-Based Card Games

Date Out: Tuesday, September 13

Due Date: Tuesday, September 27

This intermediate programming assignment will require you to use good OO programming practices with C#, and give you lots of practice at implementing methods and following a specification.

This is an individual programming assignment. Start early. Start early. Start early. Ask questions on Piazza.

###The Assignment

Early card games for computers were written on the command-line, with similar to this:

>Welcome to Blackjack!<br>
You have been dealt the seven of clubs.<br>
You have been dealt the six of hearts.<br>
Hit or Stand (H/S)?

In this assignment, we will take an object-oriented approach to the writing a card game. Because most card games have the same objects (suit, rank, card, hand, deck), the implementation of different card games can be greatly simplified using object-oriented programming. That is, although we will program two games in this assignment, the vast majority of the code needs to be written only once.

But, each game is indeed different. In general, there are three major items that that do change from game to game:

1. the evaluation of a hand
2. the composition of a hand (e.g. in blackjack you initially receive two cards whereas in draw poker you receive five)
3. in some cases, which cards are present in the deck

In this assignment you will implement both: (1) CardCount and (2) Blackjack by utilizing base card game classes that you will also write.

###API: Follow this exactly for the base classes

Create a <b>Rank</b> class, which will specify the rank values for a standard deck of cards. Ranks are established in the following ascending order: 2,3,4,5,6,7,8,9,10,J,Q,K,A. (This class could be extended for the implementation of games with specialty decks. For example, the game "Spanish 21" does not have any cards with a 10 rank in its deck.) The class should define the following static fields: TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE. The class should also define a static field List<Rank>: VALUES, which lists all rank values in the deck. The following methods should be defined:

1. int CompareTo(Rank OtherRankObject): returns 0 if the ranks are the same, -1 if this object has a lower rank than the other object, 1 if this object has a higher rank than the other object.
2. string GetSymbol(): the symbol associated with the rank (e.g. Q)
3. string GetName(): the name associated with the rank (e.g. Queen)
4. string ToString(): the name associated with the rank

Create a <b>Suit</b> class, which will be very similar to <b>Rank</b>. Here, the necessary static fields are: CLUBS, DIAMONDS, HEARTS, SPADES, VALUES. The methods are: CompareTo, GetSymbol, GetName, ToString.

Create a <b>Card</b> class, which will represent of a single playing card. A card consists of a suit value (e.g. hearts, spades) and a rank value (e.g. ace, 7, king). A card object is immutable; once instantiated, the values cannot change. The class will have a constructor: Card(Suit, Rank). It will have the following methods:

1. int CompareTo(Card OtherCardObject): returns a 0 if the cards are the same, -1 if this card would be sorted lower than the other card, 1 if this object would be sorted higher than the other card.
2. Rank GetRank(): returns the rank of this card
3. Guit GetSuit(): returns the suit of this card
4. String ToString(): returns a description of this card

Create a <b>Deck</b> class, which represents a "deck" of playing cards. In order to have maximum flexibility, this class does not implement a standard deck of playing cards. Rather, it only provides the functionality of a deck of cards. When the Deck object is instantiated elsewhere, it is then populated with the set of playing cards appropriate for the card game being implemented. This allows for proper implementation of card games such as pinochle (a 48-card deck containing only aces, nines, tens, jacks, queens, and kings in all four suits) or Blackjack (where six standard decks are used for a game). There will be one constructor: Deck(), which creates an empty deck of cards. Also implement the following methods:

1. void AddCard(card): adds a card to the deck
2. Card DealOne(): deal one card from the deck
3. int GetCardsRemaining(): returns the number of cards remaining in the current deck
4. int GetDeckSize(): returns the size of a full deck of cards
5. bool IsEmpty(): returns true if the deck is empty
6. void Shuffle(): shuffles the deck of cards that are present in the deck
7. void RestoreDeck(): resets the deck back to a full deck, by replacing any cards that were dealt out.

###Implementing 2 games

Create an <b><i>abstract</b></i> <b>Hand</b> superclass that will represent the basic functionality for a hand of cards. Extensions of this class will provide the definition of what constitutes a hand for that game and how hands are compared to one another. Implement the following methods:

1. void AddCard(Card): adds a card to this hand
2. abstract int CompareTo(Hand OtherHandObject): compares two hands
3. bool ContainsCard(Card): returns true if the card is in this hand, false otherwise
4. void DiscardHand(): throws away all cards in the hand, leaving an empty hand
5. int FindCard(Card): searches the hand for the first occurence of the specified card and returns the index
6. Card GetCardAtIndex(int): obtains the card stored at the specified location in the hand
7. int GetNumberOfCards(): returns the number of cards in the hand
8. bool IsEmpty(): returns true if the hand is empty, false otherwise
9. Card RemoveCard(Card): removes the first occurence of the specified card from this hand
10. Card RemoveCard(int): removes the card at the specified index position from this hand
11. abstract int EvaluateHand(): evaluates the hand, returns an integer corresponding to the rating of the hand.
12. string ToString(): a description of this hand, which includes all cards in the hand

Create a <b>CardCountHand</b>, whose class will inherit from <b>Hand</b>. In CardCount, aces are worth 1, twos are worth 2, ..., and face cards (jacks, queens, kings) are worth 10. The value of a hand is equal to the summation of the points of all the cards held in the hand. The two <b><i>abstract</b></i> methods in <b>Hand</b> should be defined here, specific for this game.

Also create a <b>BlackJackHand</b>, whose class also inherits from <b>Hand</b>.

Create a <b>CardCountGame</b>, where two <b>CardCountHand</b> instances are created. Both players are dealt eight cards from a standard deck of 52 cards. Output the hands of both players, the evaluation of both hands, and the number of cards remaining in the deck.

Create a <b>BlackJackGame</b>. This game will be a little more interactive than <b>CardCountGame</b>. For simplicity, we won't implement a full casino-style game (splitting, doubling down, etc.). Create a deck that is six sets of the standard 52 cards. Repeately deal cards to the player (as shown on the top of this HW), until the user wishes to STAND. Then repeately deal cards to the computer (who will keep HITTING until they get to 17.) Both the player and computer automatically lose if either one exceeds 21. (For simplicity, let's presume that aces are always worth 11.) Compare the hands against each other (unless one player has already lost), and output the winner.

###You must use Git along the way for version control.

Commit often. Commits are cheap.

###Submission instructions

Submit your code to the D2L coursepage "Assignments" module.
