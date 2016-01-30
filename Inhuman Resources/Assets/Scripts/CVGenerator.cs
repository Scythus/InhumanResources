using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CVGenerator {


    public CVGenerator()
    {

    }



	public CV generateCV(Candidate candidate)
    {
        // Generate a CV object for a given candidate
        string cvText = "";
        cvText += makeHeader(candidate);
        cvText += makeJobHistory(candidate);

        List<string> skillHobbies = generateSkillHobbies(candidate);
        cvText += skillHobbies[0]+"\n";
        cvText += skillHobbies[1];

        CV cv = new CV(candidate, cvText);
        return cv;
    }

    private string makeHeader(Candidate candidate)
    {
        string dob = Random.Range(1, 28).ToString() + "/";
        dob += Random.Range(1, 12).ToString() + "/";
        dob += calculateDOB(candidate);

        string headerText = "Date of Birth: " + dob + "\n";

        return headerText;
    }

    private string makeJobHistory(Candidate candidate)
    {
        // Get the job history for a candidate
        int numJobs = calculateNumberOfJobs(candidate.getAge());
        string jobList = "";
        for (int x=0; x<numJobs; x++)
        {
            string job = generateJob(candidate);
            jobList += job;
            jobList += "\n";
        }
        string jobOutput = "Employment History:\n\n";
        jobOutput += jobList;
        return jobOutput;
    }

    // Calculates the number of jobs held
    // Assumes that jobs lasted at least 2 years, and no more than 12 years
    private int calculateNumberOfJobs(int age)
    {
        float workingYears = age - 17;
        int minJobs = Mathf.CeilToInt(workingYears / 12);
        int maxJobs = Mathf.CeilToInt(workingYears / 6);
        int numJobs = Random.Range(minJobs, maxJobs);
        return numJobs;
    }

    private string generateJob(Candidate candidate)
    {
        return JobsGenerator.generateJobForCandidate(candidate);
    }

    private List<string> generateSkillHobbies(Candidate candidate)
    {
        HobbyGenerator hg = new HobbyGenerator();
        List<string[]> skillHobbies = hg.generateSkillsHobbies(candidate);
        string skills = "Skills: \n";
        string hobbies = "Hobbies: \n";
        foreach (string[] item in skillHobbies)
        {
            if (item[0] == "skill")
            {
                skills += item[1] + "\n";
            } else
            {
                hobbies += item[1] + "\n";
            }
        }
        return new List<string> { skills, hobbies };
    }

    private string calculateDOB(Candidate candidate)
    {
        return (2016 - candidate.getAge()).ToString();
    }
}
