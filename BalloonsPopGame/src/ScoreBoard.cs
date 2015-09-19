namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;

    public abstract class ScoreBoard
    {
        public static void PrintTopFive(string[,] playersTable)
        {
            List<Player> finalScore = new List<Player>();

            for (int i = 0; i < 5; ++i)
            {
                if (playersTable[i, 0] == null)
                {
                    break;
                }

                finalScore.Add(new Player(int.Parse(playersTable[i, 0]), playersTable[i, 1]));
            }

            finalScore.Sort();
            Console.WriteLine("---------TOP FIVE CHART-----------");
            for (int i = 0; i < finalScore.Count; ++i)
            {
                Player slot = finalScore[i];
                Console.WriteLine("{2}.   {0} with {1} moves.", slot.Name, slot.Value, i + 1);
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
