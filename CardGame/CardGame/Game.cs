using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    enum CardSuit
    {
        Six = 0,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
        
    }
    class Game
    {        
        private List<Card> CardDeck = new();
        private List<string> CardTypeList = new() { "Club", "Heart", "Spade", "Diamond" };
        private List<CardSuit> CardSuitList = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>().ToList();//new() { "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        private Player FirstPlayer = new();
        private Player SecondPlayer = new();
        private void CreateDeck()
        {
            for (int i = 0; i < CardSuitList.Count; i++)
            {
                for (int j = 0; j < CardTypeList.Count; j++)
                {
                    CardDeck.Add(new Card(CardTypeList[j],CardSuitList[i]));
                }
            }
        }

        private void PrintDeck()
        {
            for (int i = 0; i < CardDeck.Count; i++)
            {
                Console.WriteLine($"{CardDeck[i].CardSuit} {CardDeck[i].CardType}");
            }
        }

        private void MixDeck()
        {
            Random random = new();

            for (int i = 0; i < random.Next(24, 36); i++) 
            {
                int FirstCardId = random.Next(0, 36);
                int SecondCardId = random.Next(0, 36);
                
                if(FirstCardId != SecondCardId)
                {
                    var temp = CardDeck[FirstCardId];
                    CardDeck[FirstCardId] = CardDeck[SecondCardId];
                    CardDeck[SecondCardId] = temp;
                }
            }
        }

        private void SplitPlayerCards()
        {
            for (int i = 0; i < CardDeck.Count; i++) 
            {
                if (i % 2 == 0)
                    FirstPlayer.AvailableCards.Add(CardDeck[i]);
                else
                    SecondPlayer.AvailableCards.Add(CardDeck[i]);
            }
        }      

        public void StartGame()
        {
            CreateDeck();
            MixDeck();
            SplitPlayerCards();

            int Winner = 0;
            ConsoleKeyInfo PressedButton;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\tPress space to start!");
            Console.ResetColor();
            PressedButton = Console.ReadKey();
            Console.Clear();

            while (PressedButton.Key != ConsoleKey.Escape && PressedButton.Key == ConsoleKey.Spacebar && !ChooseWinner(FirstPlayer,SecondPlayer,out Winner)) 
            {
                OneStep();
                int MaxListSize = FindMaxSize(FirstPlayer.AvailableCards, SecondPlayer.AvailableCards);
                Console.WriteLine("\n");
                Console.WriteLine("First deck\tSecond deck");
                for (int i = 0; i < MaxListSize; i++)
                {
                    if(i < FirstPlayer.AvailableCards.Count)
                    {
                        Console.Write($"{FirstPlayer.AvailableCards[i].CardSuit} {FirstPlayer.AvailableCards[i].CardType}\t");
                    }
                    else
                    {
                        Console.Write("\t\t");
                    }
                    if (i < SecondPlayer.AvailableCards.Count)
                    {
                        Console.WriteLine($"{SecondPlayer.AvailableCards[i].CardSuit} {SecondPlayer.AvailableCards[i].CardType}");
                    }
                    else
                    {
                        Console.WriteLine("\t\t");
                    }
                }
                PressedButton = Console.ReadKey();
                
                Console.Clear();
            }

            switch(Winner)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\tFirst player Won!");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\tSecond player Won!");
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\t\tIt's time for tie!");
                        break;
                    }
            }
        }

        private void OneStep()
        {         
            if (FirstPlayer.AvailableCards[0].CardSuit < SecondPlayer.AvailableCards[0].CardSuit)
            {
                Console.WriteLine($"{FirstPlayer.AvailableCards[0].CardSuit} {FirstPlayer.AvailableCards[0].CardType} < {SecondPlayer.AvailableCards[0].CardSuit} {SecondPlayer.AvailableCards[0].CardType}");
                Console.WriteLine("\nSecond player take cards!");

                SwapCardToEnd(ref SecondPlayer.AvailableCards);
                SecondPlayer.AvailableCards.Add(FirstPlayer.AvailableCards[0]);
                FirstPlayer.AvailableCards.RemoveAt(0);
            }
            else if(FirstPlayer.AvailableCards[0].CardSuit == SecondPlayer.AvailableCards[0].CardSuit)
            {
                Console.WriteLine($"{FirstPlayer.AvailableCards[0].CardSuit} {FirstPlayer.AvailableCards[0].CardType} == {SecondPlayer.AvailableCards[0].CardSuit} {SecondPlayer.AvailableCards[0].CardType}");
                Console.WriteLine("\nFirst player take cards!");

                SwapCardToEnd(ref FirstPlayer.AvailableCards);
                FirstPlayer.AvailableCards.Add(SecondPlayer.AvailableCards[0]);
                SecondPlayer.AvailableCards.RemoveAt(0);
            }
            else if(FirstPlayer.AvailableCards[0].CardSuit > SecondPlayer.AvailableCards[0].CardSuit)
            {
                Console.WriteLine($"{FirstPlayer.AvailableCards[0].CardSuit} {FirstPlayer.AvailableCards[0].CardType} > {SecondPlayer.AvailableCards[0].CardSuit} {SecondPlayer.AvailableCards[0].CardType}");
                Console.WriteLine("\nFirst player take cards!");

                SwapCardToEnd(ref FirstPlayer.AvailableCards);
                FirstPlayer.AvailableCards.Add(SecondPlayer.AvailableCards[0]);
                SecondPlayer.AvailableCards.RemoveAt(0);
            }
            
            
        }

        private bool ChooseWinner(Player FPlayer, Player SPlayer,out int Winner)
        {
            if(FPlayer.AvailableCards.Count == 0)
            {
                Winner = 2;
                return true;
            }
            else if(SPlayer.AvailableCards.Count == 0)
            {
                Winner = 1;
                return true;
            }
            else if(FPlayer.AvailableCards.Count == 0 && SPlayer.AvailableCards.Count == 0)
            {
                Winner = 3;
                return true;
            }

            Winner = 0;
            return false;
        }

        private void SwapCardToEnd(ref List<Card> cards)
        {
            var temp = cards[0];
            cards.Add(temp);
            cards.RemoveAt(0);
        }

        private int FindMaxSize(List<Card> FirstList, List<Card> SecondList)
        {
            if (FirstList.Count > SecondList.Count || (FirstList.Count == SecondList.Count))
                return FirstList.Count;
            else if (FirstList.Count < SecondList.Count)
                return SecondList.Count;

            return 0;
        }
            
    }
}
