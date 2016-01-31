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
        if(skillHobbies[0].Length != 9)
            cvText += skillHobbies[0];
        if(skillHobbies[1].Length != 9)
            cvText += skillHobbies[1];

        cvText += doctorsNote(candidate);

        Sprite cvPic = candidate.getCVPic();

        CV cv = new CV(candidate, cvText, cvPic);
        return cv;
    }

    private string makeHeader(Candidate candidate)
    {
        string dob = Random.Range(1, 28).ToString() + "/";
        dob += Random.Range(1, 12).ToString() + "/";
        dob += calculateDOB(candidate);

        string headerText = "Date of Birth: " + dob + "\n";
        headerText += "Gender: " + candidate.getGender()+ "\n\n";

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
        string jobOutput = "Employment History:\n";
        jobOutput += jobList;
        return jobOutput;
    }

    // Calculates the number of jobs held
    // Assumes that jobs lasted at least 2 years, and no more than 12 years
    private int calculateNumberOfJobs(int age)
    {
        float workingYears = age - 17;
        int minJobs = Mathf.CeilToInt(workingYears / 12);
        int maxJobs = (Mathf.CeilToInt(workingYears / 6)) < 5 ? Mathf.CeilToInt(workingYears / 6) : 5;
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
        Dictionary<string, string> skillHobbies = hg.generateSkillsHobbies(candidate);
        string skills = "\nSkills:\n";
        string hobbies = "\nHobbies:\n";
        foreach (string item in skillHobbies.Keys)
        {
            if (skillHobbies[item] == "skill")
            {
                skills += item + "\n";
            } else
            {
                hobbies += item + "\n";
            }
        }
        return new List<string> { skills, hobbies };
    }

    private string calculateDOB(Candidate candidate)
    {
        return (1920 - candidate.getAge()).ToString();
    }

    private string doctorsNote(Candidate candidate) {
        string note = "\nDoctors Psychiatric Assessment: ";

        if (candidate.getSanity() < 25) {
            note += "subject suffers from multiple dellusions, phobias, and psychosis - should be considered dangerous and restrained at all times.";
        }
        else if (candidate.getSanity() < 50)
        {
            note += "past traumas have made the subject paranoid and prone fits of frenzy. Recomend medication.";
        }
        else if (candidate.getSanity() < 75)
        {
            note += "subject is neurotic, and has a mild personality disorder. Recomend therapy.";
        }
        else
        {
            note += "subject is healthy. No further action.";
        }

        return note;
    }
}
