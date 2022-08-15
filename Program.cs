using System;
using System.Collections.Generic;
using System.Linq;

namespace pickem_simulator
{
    class Program
    {
        public static int GamesToSimulate = 10000;
        static void Main(string[] args)
        {
            RunSimulation(15, 7, 1, false);
            RunSimulation(15, 7, 2, false);
            RunSimulation(16, 7, 1, false);
            RunSimulation(16, 7, 2, false);
            RunSimulation(16, 7, 1, true);
            RunSimulation(16, 5, 1, true);
            RunSimulation(16, 4, 1, true);
            RunSimulation(16, 3, 1, true);
            RunSimulation(16, 8, 1, false);
            RunSimulation(16, 8, 2, false);
            RunSimulation(16, 9, 1, false);
            RunSimulation(16, 9, 2, false);
        }

        public static void RunSimulation(int numberOfPlayers, int numberOfGames, int numberOfKeyPicks, bool rankedMode)
        {
            List<Week> allWeeks = new List<Week>();
            for (int i = 0; i < GamesToSimulate; i++)
            {
                Week w = new Week(numberOfPlayers, numberOfGames, numberOfKeyPicks, rankedMode);
                allWeeks.Add(w);
            }

            int numberOfWeeksWithTie = allWeeks.Where(w => w.WeekWasTie).Count();
            Console.WriteLine($"{GamesToSimulate} games, {numberOfPlayers} players, {numberOfGames} games, {numberOfKeyPicks} key pick, ranked mode={rankedMode}: {numberOfWeeksWithTie} ties");
        }
    }
}
