using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Cards
{
    private string suit;
    private string card;
    private int rank;
    public Cards()
    {
        suit = "None";
        card = "None";
        rank = 0;
    }
    public Cards(string _suit, string _card)
    {
        if (_suit == "Diamonds" || _suit == "Hearts" || _suit == "Spades" || _suit == "Clubs")
        {
            suit = _suit;
        }
        switch (_card)
        {
            case "Ace":
                {
                    card = _card;
                    rank = 13;
                    break;
                }
            case "King":
                {
                    card = _card;
                    rank = 12;
                    break;
                }
            case "Queen":
                {
                    card = _card;
                    rank = 11;
                    break;
                }
            case "Jack":
                {
                    card = _card;
                    rank = 10;
                    break;
                }
            case "10":
                {
                    card = _card;
                    rank = 9;
                    break;
                }
            case "9":
                {
                    card = _card;
                    rank = 8;
                    break;
                }
            case "7":
                {
                    card = _card;
                    rank = 6;
                    break;
                }
            case "6":
                {
                    card = _card;
                    rank = 5;
                    break;
                }
            case "5":
                {
                    card = _card;
                    rank = 4;
                    break;
                }
            case "4":
                {
                    card = _card;
                    rank = 3;
                    break;
                }
            case "3":
                {
                    card = _card;
                    rank = 2;
                    break;
                }
            case "2":
                {
                    card = _card;
                    rank = 1;
                    break;
                }
        }
    }
    public string GetCard()
    {
        return card;
    }
    public string GetSuit()
    {
        return suit;
    }
    public void SetCard(string _card)
    {
        switch (_card)
        {
            case "Ace":
                {
                    card = _card;
                    rank = 13;
                    break;
                }
            case "King":
                {
                    card = _card;
                    rank = 12;
                    break;
                }
            case "Queen":
                {
                    card = _card;
                    rank = 11;
                    break;
                }
            case "Jack":
                {
                    card = _card;
                    rank = 10;
                    break;
                }
            case "10":
                {
                    card = _card;
                    rank = 9;
                    break;
                }
            case "9":
                {
                    card = _card;
                    rank = 8;
                    break;
                }
            case "7":
                {
                    card = _card;
                    rank = 6;
                    break;
                }
            case "6":
                {
                    card = _card;
                    rank = 5;
                    break;
                }
            case "5":
                {
                    card = _card;
                    rank = 4;
                    break;
                }
            case "4":
                {
                    card = _card;
                    rank = 3;
                    break;
                }
            case "3":
                {
                    card = _card;
                    rank = 2;
                    break;
                }
            case "2":
                {
                    card = _card;
                    rank = 1;
                    break;
                }
            default:
                {
                    card = "None";
                    rank = 0;
                    break;
                }
        }
    }   
    public void SetSuit(string _suit)
    {
        if (_suit == "Diamonds" || _suit == "Hearts" || _suit == "Spades" || _suit == "Clubs")
        {
            suit = _suit;
        }
    }
    public void ToString(Cards Card)
    {
        Console.WriteLine("{0} of {1} and is rank {2}", card, suit, rank);
        Console.WriteLine("Face Card: {0}", this.IsFaceCard(card));
        Console.WriteLine("Is Red: {0}", this.IsRed(suit));
        Console.WriteLine("Is Black: {0}", this.IsBlack(suit));
        Console.WriteLine("Is Equals: {0}", this.Equals(Card));
        Console.WriteLine("Is Same Rank: {0}", this.HasSameRank(Card));
        Console.WriteLine("Is Same Suit: {0}", this.HasSameSuit(Card));
        Console.WriteLine("Is Greater Rank: {0}", this.HasGreaterRank(Card));
    }

    public bool IsFaceCard(string card)
    {
        if (card == "King" || card == "Queen" || card == "Jack")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsRed(string suit)
    {
        if (suit == "Hearts" || suit == "Diamonds")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsBlack(string suit)
    {
        if (suit == "Clubs" || suit == "Spades")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Equals(Cards c)
    {
        if (this.card == c.card)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasSameRank(Cards c)
    {
        if (this.rank == c.rank)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasSameSuit(Cards c)
    {
        if (this.suit == c.suit)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasGreaterRank(Cards c)
    {
        if (this.rank > c.rank)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}
class MainClass
{
    static void Main()
    {
        bool Continue = true;
        Random rnd = new Random();
        var Suits = new List<string> { "Diamonds", "Hearts", "Spades", "Clubs" };
        var Cards = new List<string>{ "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        do
        {
            Console.Clear();
            var CardCard = rnd.Next(Cards.Count);
            var Card2Card = rnd.Next(Cards.Count);
            var CardSuit = rnd.Next(Suits.Count);
            var Card2Suit = rnd.Next(Suits.Count);
            Cards Card = new Cards(Suits[CardSuit], Cards[CardCard]);
            Cards Card2 = new Cards(Suits[Card2Suit], Cards[Card2Card]);
            Card.ToString(Card2);
            Console.WriteLine("---------------------------------");
            Card2.ToString(Card);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Press Enter for More Cards. If your done, type 'done'");
            if(Console.ReadLine() == "done")
            {
                break;
            }
        } while (Continue != false);
        Console.ReadLine();
    }
}
//Card Class
//This class will have all the functions, it will use them to assign the cards values to be used elsewhere.
//Variables: suit, type, number

//ToString
//This will print out the card and its info.


//IsFaceCard
//This will take the cards suit as an input.
//This will check if the card is a face card.
//output will be a bool or 1 or 0.

//IsRed
//This will take the cards suit as an input.
//This will check if the card is red.
//output will be a bool or 1 or 0.

//IsBlack
//This will take the cards suit as an input.
//This will check if the card is black.
//output will be a bool or 1 or 0.

//Equals
//This will take the other card as input.
//This checks if the card is equal to another card.
//output will be a bool or 1 or 0.

//HasSameRank
//This will take the other card as input.
//This checks if the card has the same ranks as another.
//output will be a bool or 1 or 0.

//HasSameSuit
//This will take the other card as input.
//This checks if the card has the same suit as another.
//output will be a bool or 1 or 0.

//HasGreaterRank
//This will take the other card as input.
//This check if the card has a higher rank then another.
//output will be a bool or 1 or 0.



//MainClass
//This will access all the methods.
//eventually ending up printing out the card.
