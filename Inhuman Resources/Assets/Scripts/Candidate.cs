using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Candidate {

    Dictionary<string, int> stats;

	public Candidate()
    {
        stats = new Dictionary<string, int>();

        stats.Add("purity", 0);
        stats.Add("intelligence", 0);
        stats.Add("gullability", 0);
        stats.Add("sorcery", 0);
        stats.Add("dominion", 0);

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

    private int generateRandomStat()
    {
        Random rand = new Random();

    }
}
