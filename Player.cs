using GoFish;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GoFish
{
    public class Player
    {
        private string name;
        private List<Card> hand = new List<Card>();
        private int points = 0;
               


        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        //string to show the cards in the players hand
        public string ShowHand()
        {
            string handStr = "";

            foreach(Card card in hand)
            {
                handStr += card.ToString() + " ";

            }
            return handStr;
        }


        
               

        public bool HasFourOfAKind()      // A method do check if a player have 4 of a kind 
        {            
            List<string> rankList = new List<String>(new string[]{"A","2","3", "4","5", "6", "7", "8", "9", "10", "J", "Q", "K"});
            for(int index = 0; index < rankList.Count; index++){
                int sameCard = 0;

                // Looking at cards on hand
                for(int card = 0; card < hand.Count; card++){
                    if(hand[card].Rank == rankList[index]){
                        sameCard++;
                    }
                }
                //checking if there are 4 of the same card on your hand
                if(sameCard == 4){
                    points++;
                    FourOfAKindRemove(rankList[index]); 
                    return true;
                }
            }
            return false;
        }

        private void FourOfAKindRemove(string rankToRemove)  // removes the cards from the game if you get 4 of a kind
        {
            hand.RemoveAll(card => card.Rank == rankToRemove);
        }

        
       public List<Card> GotCard(string cardToCheck) // Method for checking opposing player hand if they have the Rank we're searching for
       
        {
          List<Card> stealCards = new List<Card>();

            for(int i = 0; i < hand.Count; i++ )
            {
                if (hand[i].Rank == cardToCheck) {

                    Card stealCard = hand[i];
                    stealCards.Add(stealCard);
                    hand.RemoveAt(i);
                                      
                }
            }
            return stealCards;
       }

        public void AddStolenCards(List<Card> stolenCards)
        {
            for (int i = 0; i < stolenCards.Count; i++)
            {
                hand.Add(stolenCards[i]); 
            }

        }

        

        public string Name { get => name; set => name = value; }
        public List<Card> Hand { get => hand; set => hand = value; }
        public int Points { get => points; set => points = value; }
        
    }
}
