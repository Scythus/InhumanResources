using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Candidate
{

    Dictionary<string, int> stats;
    Dictionary<string, int> perceivedStats;

    // Basic Stats
    int age;
    string name;
    int sanity;
    // True if female, false if male
    bool genderFemale;

    // Picture
    Sprite cvPic;

    // Advanced Stats
    public string[] statNames = new string[] { "morality", "fervor", "intelligence", "ambition", "physique" };

    // Constructor for candidate
    public Candidate(ref List<Sprite> maleSprites, ref List<Sprite> femaleSprites)
    {
        this.stats = new Dictionary<string, int>();

        // Randomly pick male or female
        genderFemale = (Random.Range(0, 2) == 1);

        // Basic Stats - these don't have perceived values
        age = generateRandomStat(18, 70);
        name = NameGenerator.generateName(getGender());
        sanity = Random.Range(1, 100);

        // Mug Shot
        if (getGender() == "Male")
        {
            cvPic = maleSprites[Random.Range(0, maleSprites.Count)];
            maleSprites.Remove(cvPic);
        } else
        {
            cvPic = femaleSprites[Random.Range(0, femaleSprites.Count)];
            femaleSprites.Remove(cvPic);
        }

        // Generate random stats for all stats in statNames between 1 and 100
        generateStats(statNames);

        // Generate perceived stats which differ from true stats by up to (-/+)10.
        perceivedStats = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> stat in this.stats)
        {
            perceivedStats.Add(stat.Key, (stat.Value + Random.Range(-10, 10)));
        }

    }

    public string getGender()
    {
        if (genderFemale == true)
        {
            return "Female";
        } else
        {
            return "Male";
        }
    }

    public Sprite getCVPic()
    {
        return cvPic;
    }

    public int getAge()
    {
        return age;
    }

    public string getName()
    {
        return name;
    }

    public int getSanity()
    {
        return sanity;
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
        }
        else
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

    public void debugCandidate()
    {
        Debug.Log("Printing Candidate");
        foreach (string stat in statNames)
        {
            Debug.Log("Stat " + stat + " is " + getStat(stat));
        }
    }
}
