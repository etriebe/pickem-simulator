using System;
using System.Collections.Generic;

public class PlayerWeek
{
    public List<Pick> Picks;

    public int TotalPoints;

    public PlayerWeek(int numberOfGames, int numberOfKeyPicks, bool rankedMode)
    {
        this.TotalPoints = -1;
        this.Picks = new List<Pick>();
        int numberOfKeyPicksSoFar = 0;
        for (int j = 0; j < numberOfGames; j++)
        {
            bool useKeyPick = numberOfKeyPicksSoFar < numberOfKeyPicks;
            this.Picks.Add(new Pick(useKeyPick));
            numberOfKeyPicksSoFar++;
        }

        int pickNumber = 1;
        foreach (Pick p in this.Picks)
        {
            if (!p.CorrectPick)
            {
                pickNumber++;
                continue;
            }

            if (rankedMode)
            {
                this.TotalPoints += pickNumber;
            }
            else if (p.IsKeyPick)
            {
                this.TotalPoints += 2;
            }
            else
            {
                this.TotalPoints += 1;
            }

            pickNumber++;
        }
    }
}