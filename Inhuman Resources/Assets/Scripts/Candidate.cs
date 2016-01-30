﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Candidate {

    Dictionary<string, int> stats;
    Dictionary<string, int> perceivedStats;

    // Basic Stats
    int age;

    // Advanced Stats
    string[] statNames = new string[] { "purity", "dominion", "aura", "morality", "obedience", "intelligence", "ambition" };


    // Constructor for candidate
    public Candidate()
    {
        this.stats = new Dictionary<string, int>();

        // Basic Stats - these don't have perceived values
        age = generateRandomStat(18, 70);

        // Generate random stats for all stats in statNames between 1 and 100
        generateStats(statNames);

        // Generate perceived stats which differ from true stats by up to (-/+)10.
        perceivedStats = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> stat in this.stats)
        {
            perceivedStats.Add(stat.Key, (stat.Value + Random.Range(-10, 10)));
        }

    }

    public int getAge()
    {
        return age;
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
            return 50;
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

    // Generate a random stat between 1 and 100.
    private int generateRandomStat()
    {
        int number = Random.Range(1, 100);
        return number;

    }

    // Overridden function to allow user to choose the limits
    private int generateRandomStat(int min, int max)
    {
        int number = Random.Range(min, max);
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
