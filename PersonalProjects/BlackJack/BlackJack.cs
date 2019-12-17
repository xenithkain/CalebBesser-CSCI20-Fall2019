using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class main
{
    public static void Black()
    {
        Deck.Deck_Make();
    }
}
class Card
{
    private string suit;
    private string card;
    private int rank;
    public Card()
    {
        suit = "None";
        card = "None";
        rank = 0;
    }
    public Card(string _suit, string _card)
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
    public bool HasSameRank(Card c)
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

    public bool HasSameSuit(Card c)
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

    public bool HasGreaterRank(Card c)
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
class Deck
{
    public static void Deck_Make()
    {
        Card[] Deck1_Cards = new Card[53];
        Card[] Deck1_Suits = new Card[53];
        for (int i = 0; i <= 13; i++)
        {
            Deck1_Suits[i].SetSuit("Hearts");
            
        }
        for (int i = 14; i <= 26; i++)
        {
            Deck1_Suits[i].SetSuit("Diamonds");
        }
        for (int i = 27; i <= 39; i++)
        {
            Deck1_Suits[i].SetSuit("Spades");
        }
        for (int i = 40; i <= 52; i++)
        {
            Deck1_Suits[i].SetSuit("Clubs");
        }
        Deck1_Cards[0].SetCard("Ace");
        Deck1_Cards[1].SetCard("2");
        Deck1_Cards[2].SetCard("3");
        Deck1_Cards[3].SetCard("4");
        Deck1_Cards[4].SetCard("5");
        Deck1_Cards[5].SetCard("6");
        Deck1_Cards[6].SetCard("7");
        Deck1_Cards[7].SetCard("8");
        Deck1_Cards[8].SetCard("9");
        Deck1_Cards[9].SetCard("10");
        Deck1_Cards[10].SetCard("Jack");
        Deck1_Cards[11].SetCard("Queen");
        Deck1_Cards[12].SetCard("King");
        Deck1_Cards[13].SetCard("Ace");
        Deck1_Cards[14].SetCard("2");
        Deck1_Cards[15].SetCard("3");
        Deck1_Cards[16].SetCard("4");
        Deck1_Cards[17].SetCard("5");
        Deck1_Cards[18].SetCard("6");
        Deck1_Cards[19].SetCard("7");
        Deck1_Cards[20].SetCard("8");
        Deck1_Cards[21].SetCard("9");
        Deck1_Cards[22].SetCard("10");
        Deck1_Cards[23].SetCard("Jack");
        Deck1_Cards[24].SetCard("Queen");
        Deck1_Cards[25].SetCard("King");
        Deck1_Cards[26].SetCard("Ace");
        Deck1_Cards[27].SetCard("2");
        Deck1_Cards[28].SetCard("3");
        Deck1_Cards[29].SetCard("4");
        Deck1_Cards[30].SetCard("5");
        Deck1_Cards[31].SetCard("6");
        Deck1_Cards[32].SetCard("7");
        Deck1_Cards[33].SetCard("8");
        Deck1_Cards[34].SetCard("9");
        Deck1_Cards[35].SetCard("10");
        Deck1_Cards[36].SetCard("Jack");
        Deck1_Cards[37].SetCard("Queen");
        Deck1_Cards[38].SetCard("King");
        Deck1_Cards[39].SetCard("Ace");
        Deck1_Cards[40].SetCard("2");
        Deck1_Cards[41].SetCard("3");
        Deck1_Cards[42].SetCard("4");
        Deck1_Cards[43].SetCard("5");
        Deck1_Cards[44].SetCard("6");
        Deck1_Cards[45].SetCard("7");
        Deck1_Cards[46].SetCard("8");
        Deck1_Cards[47].SetCard("9");
        Deck1_Cards[48].SetCard("10");
        Deck1_Cards[49].SetCard("Jack");
        Deck1_Cards[50].SetCard("Queen");
        Deck1_Cards[51].SetCard("King");
        Show_Deck(ref Deck1_Cards, ref Deck1_Suits);
    }
    public static void Show_Deck(ref Card[] Deck1Cards, ref Card[] Deck1Suits)
    {
        for (int i = 0; i < Deck1Cards.Length; i++)
        {
            Console.Write(Deck1Cards[i].GetCard());
            Console.Write(" ");
        }
        for (int i = 0; i < Deck1Suits.Length; i++)
        {
            Console.Write(Deck1Suits[i].GetSuit());
            Console.Write(" ");
        }
    }
}

class Dealer
{

}
class Player
{

}
