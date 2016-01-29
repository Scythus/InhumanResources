using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Candidate {

    Dictionary<string, int> stats;
    Dictionary<string, int> perceivedStats;

    public string[] statNames = new string[] { "purity", "dominion", "aura", "morality", "obedience" };


    // Constructor for candidate
    public Candidate()
    {
        stats = new Dictionary<string, int>();

        // Generate random stats for all stats in statNames between 1 and 100
        generateStats(statNames);

        // Generate perceived stats which differ from true stats by up to (-/+)10.
        perceivedStats = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> stat in stats)
        {
            perceivedStats.Add(stat.Key, (stat.Value + Random.Range(-10, 10)));
        }

}

    public void setStat(string name, int value)
    {
        stats[name] = value;
    }

    public int getStat(string name)
    {
        if (stats.ContainsKey(name))
        {
            return stats[name];
        } else
        {
            return 0;
        }
    }

    public void setPerceivedStat(string name, int value)
    {
        perceivedStats[name] = value;
    }

    public int getPerceivedStat(string name)
    {
        if (stats.ContainsKey(name))
        {
            return perceivedStats[name];
        }
        else
        {
            return 0;
        }
    }

    private int generateRandomStat()
    {
        int number = Random.Range(1, 100);
        return number;

    }

    private void generateStats(string[] statNames)
    {
        foreach (string stat in statNames)
        {
            stats.Add(stat, generateRandomStat());
        }
    }
}
