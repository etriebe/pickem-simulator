using System;
using System.Collections.Generic;

public class PlayerWeek
{
    public List<Pick> Picks;

    public int TotalPoints;

    public PlayerWeek(int numberOfGames, int numberOfKeyPicks)
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

        foreach (Pick p in this.Picks)
        {
            if (!p.CorrectPick)
            {
                continue;
            }

            if (p.IsKeyPick)
            {
                this.TotalPoints += 2;
            }
            else
            {
                this.TotalPoints += 1;
            }
        }
    }
}