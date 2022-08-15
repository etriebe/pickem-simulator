using System;
using System.Collections.Generic;
using System.Linq;

public class Week
{
    public int PlayerCount;

    public int NumberOfGames;

    public int NumberOfKeyPicks;

    public List<PlayerWeek> PlayerPicks;

    public bool WeekWasTie;

    public bool RankedMode;

    public Week(int playerCount, int numberOfGames, int numberOfKeyPicks, bool rankedMode)
    {
        this.PlayerPicks = new List<PlayerWeek>();
        this.PlayerCount = playerCount;
        this.NumberOfGames = numberOfGames;
        this.NumberOfKeyPicks = numberOfKeyPicks;
        this.RankedMode = rankedMode;
        this.RunSimulation();
    }

    public void RunSimulation()
    {
        for (int i = 0; i < this.PlayerCount; i++)
        {
            this.PlayerPicks.Add(new PlayerWeek(this.NumberOfGames, this.NumberOfKeyPicks, this.RankedMode));
        }

        this.WeekWasTie = this.NumberInFirstPlace() > 1;
    }

    public int NumberInFirstPlace()
    {
        int maxScore = this.PlayerPicks.Max(p => p.TotalPoints);
        int numberWithMaxScore = this.PlayerPicks.Where(p => p.TotalPoints == maxScore).Count();
        return numberWithMaxScore;
    }

}