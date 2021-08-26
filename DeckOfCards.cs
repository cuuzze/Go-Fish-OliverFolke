using System;
using GoFish;
using System.Collections.Generic;
using System.Linq;

namespace GoFish
{
    public class DeckOfCards
    {

        private List<Card> cards = new List<Card>();
        


        public DeckOfCards()
        {
            string suites = "♠♥♦♣";

            string ranks = "A23456789XJQK";

            foreach (char suite in suites)
            {

                foreach (char rank in ranks)
                {
                    //char + "tom string" = tvingar den att skriva ut

                    Cards.Add(new Card(suite + "",(rank == 'X' ? "10" : rank + "")));

                }

            }
            Shuffle();
        }

        public string ShowCards()
        {
            string list = "";
            foreach(Card card in Cards) 
            {
                list += card.ShowMe() + " ";
            
            }
            return list;
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(item => rnd.Next()).ToList();

        }


        //To deal 5 cards to a player at the start of the game
        public void Deal (Player player)
        {
            List<Card> cardsToDeal = cards.GetRange(0,5);
            cards.RemoveRange(0, 5); 
            player.Hand = cardsToDeal;                      
        }

        //allows the player to draw a card from the deck
        public void DrawCard(Player player)
        {
            Card cardToDraw = cards[0];
            cards.RemoveAt(0);
            player.Hand.Add(cardToDraw);
            Console.WriteLine($"You drew: {cardToDraw}");

        }

       

        public List<Card> Cards { get => cards; set => cards = value; }
        
    }
    
}
