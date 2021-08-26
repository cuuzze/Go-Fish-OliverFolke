using System;
using GoFish;
using System.Collections.Generic;
using System.Text;

namespace GoFish
{
    public class Game
    {
        private DeckOfCards deck = new DeckOfCards();

        private Player player1 = new Player("", 0);
        private Player player2 = new Player("", 0);
        private Player currentPlayer;

        private bool gameOver = false;
        private int turn = 1;

        public Game()
        {
            InitGame(); // deal cards, get name of players
            GameLoop(); 
        }

        private void InitGame()
        {
            Console.WriteLine("\nHello! Welcome to a game of Go fish! Are you ready?");
            Console.WriteLine("\n\nWhat is your name Player one? ");
            player1.Name = Console.ReadLine();

            Console.WriteLine($"\nWelcome {player1.Name}");
            Console.Clear();

            Console.WriteLine("\nHello! Welcome to a game of Go fish! Are you ready?");
            Console.WriteLine("\n\nWhat is your name Player two? ");
            player2.Name = Console.ReadLine();
            Console.WriteLine($"\nWelcome {player2.Name}");
            Console.Clear();


            deck.Deal(player1);
            deck.Deal(player2);
        }

        private void GameLoop()
        {

            while (!gameOver)
            {
                Console.Clear();
                if (turn == 1)
                {
                    currentPlayer = player1;
                }
                else
                {
                    currentPlayer = player2;
                }

                switch (Action())
                {
                    
                    case 1:
                        
                        Console.WriteLine("You go fishing!");
                        deck.DrawCard(currentPlayer);                        
                        if (HasFourOfAKind())
                        {
                            if(turn == 1)   // is a system so that if you get for of a kind you get to go again as per the rules.
                            {
                                turn = 0;
                            }
                            else
                            {
                                turn = 1;
                            }                                                            


                        }
                        Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("You want to ask the other player if they have a value!");
                        AskForCard();
                        if (HasFourOfAKind())
                        {
                            if (turn == 1) 
                            {
                                turn = 0;
                            }
                            else
                            {
                                turn = 1;
                            }
                        }                       

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid option!");
                        Console.ReadLine();

                        if (turn == 1)   // I reused this code here  so that if you do an invalid input it will loop you until you do a correct input
                        {
                            turn = 0;
                        }
                        else
                        {
                            turn = 1;
                        }
                        break;
                }

                if (turn == 1)
                {
                    turn = 0;
                }
                else
                {
                    turn = 1;
                }

                IsGameOver();
            }
        }

        private int Action()
        {

            bool stop = false;
            do            // I did this DoWhile because the swich above breaks on using non numbers and this was a way to get around it ^^
            {                
                Console.WriteLine($"What action do you want to make {currentPlayer.Name}");
                Console.WriteLine($"\nYour current cards are: {currentPlayer.ShowHand()}");
                Console.WriteLine("\n1 : Go Fish! (Draw a card)");
                Console.WriteLine("2 : Ask opponent for a card\n");
                string action = Console.ReadLine();

                if(action == "1")     
                {
                    return Convert.ToInt32(action);
                    stop = true;

                }
                else if(action == "2")
                {
                    return Convert.ToInt32(action);

                    stop = true;
                }               
                    
                   return 0;               
                

            } while (stop == false);
            
        }

        private bool HasFourOfAKind()
        {
            if (currentPlayer.HasFourOfAKind())
            {
                Console.WriteLine($"Congratulations {currentPlayer.Name} you got four of a kind, you now have {currentPlayer.Points} Points!!!");
                Console.WriteLine("You get another turn!");
                Console.ReadLine();
                return true;

            }
            else 
            { 
                Console.WriteLine("");
                return false;

            }

        }

        private void AskForCard()
        {
            
            bool stop = false;
            string askedForCard = "";

            do
            {
                Console.Clear();
                Console.WriteLine($"\nYour current cards are: {currentPlayer.ShowHand()}");
                Console.WriteLine($"What cards do you wish to ask for {currentPlayer.Name}? type the number:" +
                "\n 1: Aces?" +
                "\n 2: Twos?" +
                "\n 3: Threes?" +
                "\n 4: Fours?" +
                "\n 5: Fives?" +
                "\n 6: Sixes?" +
                "\n 7: Sevens?" +
                "\n 8: Eights?" +
                "\n 9: Nines?" +
                "\n 10: Tens?" +
                "\n 11: Jacks?" +
                "\n 12: Queens?" +
                "\n 13: Kings?" +
                "\n");
                Console.Write("Please pick a card!: ");
                string answer = Console.ReadLine();

                if (answer == "1" ) // this was a very îneligant solution, but it was the only one i could come up with for this!
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "2")
                {                    
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "3")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "4")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "5")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "6")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "7")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "8")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "9")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "10")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "11")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "12")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else if (answer == "13")
                {
                    askedForCard = ConvertCardSwitchCase(Convert.ToInt32(answer));
                    stop = true;
                }
                else
                {
                    Console.WriteLine("Wrong input! Please write a number.");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (stop == false);         


            if (turn == 1)  // This was a solution to differenciate the different players on their turns if you decide to steal cards.
            {
                List<Card> stolenCards = player2.GotCard(askedForCard);              
                player1.AddStolenCards(stolenCards);

                Console.WriteLine($"You got {PrintCards(stolenCards)} from { player2.Name}, better luck next time!");
                Console.ReadLine();
            }
            else
            {
                List<Card> stolenCards = player1.GotCard(askedForCard);
                player2.AddStolenCards(stolenCards);
                Console.WriteLine($"You got {PrintCards(stolenCards)} from {player1.Name}");
                Console.ReadLine();
            }
        }

        private void IsGameOver() //pretty easy rules, I decided to let the game play out the entire deck even though first to 7 wins :)
        {
            if(player1.Points + player2.Points == 13)
            {
                if(player1.Points > player2.Points)
                {
                    Console.WriteLine($"Congratulations {player1.Name} you got {player1.Points} and won the game!");                   
                    Console.ReadLine();
                    gameOver = true;
                }

                else
                {
                    Console.WriteLine($"Concratulations {player2.Name} you got {player2.Points} and won the game!");
                    Console.ReadLine();
                    gameOver = true;
                }               
                
            }

        }
        private string PrintCards(List<Card> cards)   // This method is to be able to print lists of cards that You steal and is momentarily "on the table"
        {
            if(cards.Count == 0)
            {
                return "nothing this time";
            }

            StringBuilder sb = new StringBuilder();

            foreach(Card card in cards )
            {
                sb.Append(card);
            }
            return sb.ToString();
            
        }
        private string ConvertCardSwitchCase(int i)
        {
            switch (i)
            {
                case 1:
                    return "A";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "10";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                default:
                    return "";


            }
        }
    }




}
