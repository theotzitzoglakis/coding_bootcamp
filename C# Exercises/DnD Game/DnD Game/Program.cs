using System;

namespace DnD_Game
{
    class Program
    {
        public class Dice
        {
            public int sides;
            static public int rolls = 0;

            public Dice()
            {
                sides = 20;
            }

            public Dice(int sides)
            {
                this.sides = sides;
            }

            //public void Roll()
            //{
            //    rolls += 1;
            //}
            //
            //public int GetRolls()
            //{
            //    return Dice.rolls;
            //}

        }

        public class Player
        {
            public string name { get; private set; }
            public string surname { get; private set; }
            public int score;
            static Random rand = new Random();

            public Player(string x)
            {
                name = x;
                surname = "";
                score = 0;
            }
            public Player(string x, string y)
            {
                name = x;
                surname = y;
                score = 0;
            }
            public int Roll(Dice dice)
            {
                int result = rand.Next(1, dice.sides + 1);
                Dice.rolls += 1;
                return result;
            }
        public class Game
          {
              public void Play()
              {
                  //να προσπαθησω να φερω ολες τις λογικες λειτουργιες του παιχνιδιου μεσα σε αυτη την κλαση
              }
          }
        }

        static void Main(string[] args)
        {
            Dice d4 = new Dice(4);
            Dice d8 = new Dice(8);
            Dice d12 = new Dice(12);
            Dice d20 = new Dice();

            Player player1 = new Player("Nikos");
            Player player2 = new Player("Kostas", "Gianniotis");



            int round = 0;
            int result;
            while (round < 100)
            {
                int result1 = player1.Roll(d20);
                int result2 = player2.Roll(d20);
                int diff = result1 - result2;
                if (diff < 0)
                {
                    player2.score += Math.Abs(diff);
                }
                if (diff > 0)
                {
                    player1.score += diff;
                }


                if (round % 2 == 0)
                {
                    result = player1.Roll(d20);
                    Console.WriteLine(String.Format("{0} rolled {1}", player1.name, result));
                }
                else
                {
                    result = player2.Roll(d20);
                    Console.WriteLine(String.Format("{0} rolled {1}", player2.name, result));
                }
                
                round += 1;
            }

            Console.WriteLine("Total rolls: " + Dice.rolls);
            Console.WriteLine("Player 1 Score: " + player1.score);
            Console.WriteLine("Player 2 Score: " + player2.score);



            Console.ReadKey();

        }
    }
}
