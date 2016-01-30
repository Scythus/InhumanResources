using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HobbyGenerator {

    private Dictionary<string, string> outputs = new Dictionary<string, string>();

    public Dictionary<string, string> generateSkillsHobbies(Candidate candidate)
    {
        foreach (string stat in candidate.statNames)
        {
            generateHobbySkillForStat(stat, candidate);
        }
        return outputs;
    }

    public void generateHobbySkillForStat(string stat, Candidate candidate)
    {
        if (stat == "intelligence")
        {
            generateIntelligenceHobbySkill(candidate);
        } else if (stat == "morality")
        {
            generateMoralityHobbySkill(candidate);
        } else if (stat == "ambition")
        {
            generateAmbitionHobbySkill(candidate);
        } else if (stat == "fervor")
        {
            generateFervorHobbySkill(candidate);
        } else if (stat == "physique")
        {
            generatePhysiqueHobbySkill(candidate);
        }
    }

    private void generatePhysiqueHobbySkill(Candidate candidate)
    {
        int value = candidate.getPerceivedStat("physique");
        List<string[]> options = new List<string[]>();
        if (value > 70)
        {
            options.Add(checkSecondaryStat(candidate, "fervor", "Dancing", true));
            options.Add(checkSecondaryStat(candidate, "morality", "Picking on the weak", false));
            options.Add(entry("skill", "Brawling"));
            options.Add(checkSecondaryStat(candidate, "intelligence", "Familiar Husbandry", true));

        } else if (value > 50)
        {
            options.Add(entry("hobby", "Brawling"));
            options.Add(entry("hobby", "Hunger Striking"));
        } else
        {
            options.Add(checkSecondaryStat(candidate, "ambition", "Lounging", false));
            options.Add(checkSecondaryStat(candidate, "intelligence", "Reality TV Trivia", false));
            options.Add(entry("skill", "Hunger Striking"));
        }
        addOptionToOutputs(options[Random.Range(0, options.Count)]);
    }

    private void generateFervorHobbySkill(Candidate candidate)
    {
        int value = candidate.getPerceivedStat("fervor");
        List<string[]> options = new List<string[]>();
        if (value > 70)
        {
            options.Add(checkSecondaryStat(candidate, "physique", "Dancing", true));
            options.Add(checkSecondaryStat(candidate, "morality", "Pyromania", false));
            options.Add(checkSecondaryStat(candidate, "ambition", "Voodoo", true));
            options.Add(entry("skill", "Chanting"));

        }
        else if (value > 50)
        {
            options.Add(entry("hobby", "Meditation"));
            options.Add(entry("hobby", "Chanting"));
            options.Add(entry("hobby", "Sedative Experimentation"));
        }
        else
        {
            options.Add(entry("skill", "Meditation"));
            options.Add(entry("skill", "Sedative Experimentation"));
            options.Add(checkSecondaryStat(candidate, "ambition", "Sitting Quietly", false));
        }
        addOptionToOutputs(options[Random.Range(0, options.Count)]);
    }

    private void generateAmbitionHobbySkill(Candidate candidate)
    {
        int value = candidate.getPerceivedStat("ambition");
        List<string[]> options = new List<string[]>();
        if (value > 70)
        {

            options.Add(checkSecondaryStat(candidate, "intelligence", "Necromancy", true));
            options.Add(checkSecondaryStat(candidate, "morality", "Scheming", false));
            options.Add(checkSecondaryStat(candidate, "intelligence", "Ouija", false));
            options.Add(checkSecondaryStat(candidate, "fervor", "Voodoo", true));
            options.Add(entry("skill", "Puppet Mastery"));
        }
        else if (value > 50)
        {
            options.Add(entry("hobby", "Puppet Mastery"));
            options.Add(entry("hobby", "Masochism"));
        }
        else
        {
            options.Add(checkSecondaryStat(candidate, "physique", "Lounging", false));
            options.Add(checkSecondaryStat(candidate, "fervor", "Sitting Quietly", false));
            options.Add(checkSecondaryStat(candidate, "morality", "Working with children", true));
            options.Add(entry("skill", "Masochism"));
        }
        addOptionToOutputs(options[Random.Range(0, options.Count)]);
    }

    private void generateMoralityHobbySkill(Candidate candidate)
    {
        int value = candidate.getPerceivedStat("morality");
        List<string[]> options = new List<string[]>();
        if (value > 70)
        {

            options.Add(entry("skill", "Healing"));
            options.Add(entry("skill", "Charity Fundraising"));
            options.Add(checkSecondaryStat(candidate, "ambition", "Working with children", false));
        }
        else if (value > 50)
        {
            options.Add(entry("hobby", "Healing"));
            options.Add(entry("hobby", "Lying"));
            options.Add(entry("hobby", "Charity Fundraising"));
        }
        else
        {
            options.Add(checkSecondaryStat(candidate, "intelligence", "Blackmail", true));
            options.Add(checkSecondaryStat(candidate, "ambition", "Scheming", true));
            options.Add(entry("skill", "Lying"));
            options.Add(checkSecondaryStat(candidate, "physique", "Picking on the weak", true));
            options.Add(checkSecondaryStat(candidate, "fervor", "Pyromania", true));
        }
        addOptionToOutputs(options[Random.Range(0, options.Count)]);
    }

    private void generateIntelligenceHobbySkill(Candidate candidate)
    {
        int value = candidate.getPerceivedStat("intelligence");
        List<string[]> options = new List<string[]>();
        if (value > 70)
        {

            options.Add(checkSecondaryStat(candidate, "ambition", "Necromancy", true));
            options.Add(checkSecondaryStat(candidate, "morality", "Scheming", false));
            options.Add(checkSecondaryStat(candidate, "physique", "Familiar Husbandry", true));
            options.Add(entry("skill", "Tomes"));
        }
        else if (value > 50)
        {
            options.Add(entry("hobby", "Tomes"));
            options.Add(entry("hobby", "Heavy Drinking"));
        }
        else
        {
            options.Add(checkSecondaryStat(candidate, "ambition", "Ouija", true));
            options.Add(checkSecondaryStat(candidate, "physique", "Reality TV Trivia", false));
            options.Add(entry("skill", "Heavy Drinking"));
        }
        addOptionToOutputs(options[Random.Range(0, options.Count)]);
    }

    private string[] checkSecondaryStat(Candidate candidate, string secondary, string name, bool high)
    {
        bool check;
        string[] item;
        if (high)
            {
                check = (candidate.getPerceivedStat(secondary) > 70);
            } else {
                check = (candidate.getPerceivedStat(secondary) < 50);
         };
        if (check)
        {
            item = new string[] { "skill", name };
        }
        else
        {
            item = new string[] { "hobby", name };
        }

        return item;
    }

    private string[] entry(string type, string activity)
    {
        return new string[]{type, activity};
    }

    private void addOptionToOutputs(string[] option)
    {
        outputs[option[1]] = option[0];
    }
}
