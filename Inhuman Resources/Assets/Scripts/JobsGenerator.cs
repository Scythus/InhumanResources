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

        // General Sectors
        sector.Add("Retail");
        sector.Add("Education");

        // General Job Titles

        jobTitle.Add("HR Specialist");
        jobTitle.Add("Sales Assistant");
        jobTitle.Add("Accountant");
        jobTitle.Add("Trainer");

        // Low Morality Only
        if (candidate.getStat("morality") < 25)
        {
            sector.Add("Gambling Industry");
            sector.Add("Arms Industry");
            sector.Add("Banking Sector");
            sector.Add("Tobacco Industry");
            sector.Add("Fossil Fuel Industry");
            sector.Add("Pharmacutical Industry");

            jobTitle.Add("Baliff");
        }

        // High Morality Only
        if (candidate.getStat("morality") > 75)
        {
            sector.Add("Charity");
            sector.Add("Animal Protection");
            sector.Add("Environmental Agency");
            sector.Add("Social Care Agency");

            jobTitle.Add("Priest");
            jobTitle.Add("Paediatrician");
            jobTitle.Add("Surgeon");
            jobTitle.Add("Vet");
        }


        // Low Ambition Only
        if (candidate.getStat("ambition") < 25)
        {
            sector.Add("Fast Food Restaurant");
            sector.Add("Supermarket");
            sector.Add("Heavy Industry");


            jobTitle.Add("Cleaner");
            jobTitle.Add("Street Sweeper");
            jobTitle.Add("Factory Worker");
        }

        // High Ambition Only
        if (candidate.getStat("ambition") > 75)
        {
            sector.Add("International Law Company");
            sector.Add("Space Industry");

            jobTitle.Add("Lawyer");
            jobTitle.Add("CEO");
            jobTitle.Add("Financial Investor");

        }

        // Low Intelligence Only
        if (candidate.getStat("intelligence") < 25)
        {

            sector.Add("Alternative Medicine");
            sector.Add("Pyramid Scheme");

            jobTitle.Add("Tea Maker");
            jobTitle.Add("Toilet Attendant");
            jobTitle.Add("Lid Tightener");
            jobTitle.Add("Crisp Tester");

        }

        // High Intelligence Only
        if (candidate.getStat("intelligence") > 75)
        {

            sector.Add("Cutting Edge Research Company");

            jobTitle.Add("Scientist");
            jobTitle.Add("Professional Gambler");
            jobTitle.Add("High Stakes Trader");
            jobTitle.Add("Engineer");
            jobTitle.Add("Programmer");
        }

        // Low Dominion Only
        if (candidate.getStat("dominion") < 25)
        {

            jobTitle.Add("Servant");
            jobTitle.Add("Butler");
            jobTitle.Add("Waiting Staff");
            jobTitle.Add("Yes-Person");
        }

        // High Dominion Only
        if (candidate.getStat("dominion") > 75)
        {
            sector.Add("Security Firm");

            jobTitle.Add("Manager");
            jobTitle.Add("Military Officer");
        }

        // Pick sector and title at random
        string selectedTitle = jobTitle[Random.Range(0, jobTitle.Count-1)];
        string selectedSector = sector[Random.Range(0, sector.Count - 1)];

        // Format into a string and return
        string output = "\t- " + selectedTitle +", " + selectedSector;

        return output;


    }

}
