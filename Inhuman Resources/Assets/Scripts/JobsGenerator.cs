using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JobsGenerator {


    // Generate a huge list of possible jobs and industries based on the stats of the candidate
    public static string generateJobForCandidate(Candidate candidate)
    {
        // Which sector industry
        List<string> sector = new List<string>();
        // The job title
        List<string> jobTitle = new List<string>();

        int intelligence = candidate.getStat("intelligenge");
        int morality = candidate.getStat("morality");
        int ambition = candidate.getStat("ambition");
        int fervor = candidate.getStat("fervor");
        int physique = candidate.getStat("physique");
        int sanity = candidate.getSanity();

        if (intelligence > 50)
        {
            jobTitle.Add("Scientist");
            jobTitle.Add("Engineer");
            jobTitle.Add("Doctor");
            jobTitle.Add("CEO");
            jobTitle.Add("Politician");
        } else
        {
            jobTitle.Add("Reality TV Star");
            jobTitle.Add("Lid Tightener");
            jobTitle.Add("Crisp Tester");
            jobTitle.Add("Professional Drinker");
        }

        if (morality > 50)
        {
            jobTitle.Add("Doctor");
            jobTitle.Add("Volunteer");
            jobTitle.Add("Police Officer");
            jobTitle.Add("Priest");
        }
        else
        {
            jobTitle.Add("Baliff");
            jobTitle.Add("Tobacco Lobbyist");
            jobTitle.Add("Politician");
            jobTitle.Add("Mercenary");
        }

        if (ambition > 50)
        {
            jobTitle.Add("CEO");
            jobTitle.Add("Banker");
            jobTitle.Add("Politician");
            jobTitle.Add("Scientist");
            jobTitle.Add("Council Official");
            jobTitle.Add("Athlete");
            jobTitle.Add("Actor");
        }
        else
        {
            jobTitle.Add("Tea Maker");
            jobTitle.Add("Lid Tightener");
            jobTitle.Add("Clown");
            jobTitle.Add("Cat Sitter");
            jobTitle.Add("Cleaner");
        }

        if (fervor > 50)
        {
            jobTitle.Add("Actor");
            jobTitle.Add("Clown");
            jobTitle.Add("Mystic");
            jobTitle.Add("Reality TV Star");
        }
        else
        {
            jobTitle.Add("Data Entry Specialist");
            jobTitle.Add("Lid Tightener");
            jobTitle.Add("Sofa Tester");
            jobTitle.Add("Cat Sitter");
        }

        if (physique > 50)
        {
            jobTitle.Add("Mercenary");
            jobTitle.Add("Police Officer");
            jobTitle.Add("Athlete");
            jobTitle.Add("Baliff");
        }
        else
        {
            jobTitle.Add("Crisp Tester");
            jobTitle.Add("Sofa Tester");
            jobTitle.Add("Professional Drinker");
            jobTitle.Add("Professional Darts Player");
        }

        if (sanity < 50)
        {
            jobTitle.Add("Mad Scientist");
            jobTitle.Add("Data Entry Specialist");
            jobTitle.Add("Professional Drinker");
        }

        if (sanity < 25)
        {
            jobTitle.Add("DATA EXPUNGED");
        }

        if (sanity < 25)
        {
            sector.Add("DATA EXPUNGED");
        }

        sector.Add("Depository of the Holy Wyrms");
        sector.Add("Vasquez Realizations Of Paris");
        sector.Add("Apocalypse Architecture");
        sector.Add("Mckay Chemical Specialized Transportation");
        sector.Add("Huffman Progressive Fabrication");
        sector.Add("Potts Paragon Education Cargo");
        sector.Add("Berg Oil Housing");
        sector.Add("Genetics Instrument Photographic");
        sector.Add("Independent Directorate of Prefectures");
        sector.Add("The Talisman Alliance");
        sector.Add("Advocate Phylactery Guild");
        sector.Add("Consumables Of Warsaw");
        sector.Add("Cryptonautics");
        sector.Add("Mechanical Physiotech");
        sector.Add("Gyrocorp");
        sector.Add("Housing House Packaging");
        sector.Add("Singleton Office Agricultural Healthcare");
        sector.Add("Stein Advanced Science Technology");
        sector.Add("Hudson Agricultural Entertainment Recreational");
        sector.Add("Petersen Tactical Nuclear Fabrication");
        sector.Add("Minaret of the Cursed Ogre");
        sector.Add("Obsidian Repository of Secrets");
        sector.Add("Oubliette of Glass and Clarity");
        sector.Add("Eternal Hall of the Unholy");
        sector.Add("Sacred Swamp of Chaotic Enchantment");
        sector.Add("Vasquez Realizations Of Paris");

        // Pick sector and title at random
        string selectedTitle = jobTitle[Random.Range(0, jobTitle.Count)];
        string selectedSector = sector[Random.Range(0, sector.Count)];

        // Format into a string and return
        string output = "\t- " + selectedTitle +", " + selectedSector;

        return output;

    }



}
