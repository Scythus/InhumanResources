using UnityEngine;
using System.Collections;

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
        CV cv = new CV(candidate, cvText);
        return cv;
    }

    private string makeHeader(Candidate candidate)
    {
        string dob = Random.Range(1, 28).ToString() + "/";
        dob += Random.Range(1, 12).ToString() + "/";
        dob += calculateDOB(candidate);


        string headerText = "Name: Joe Bloggs\n";

        headerText += "Date of Birth: " + dob + "\n";

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
        int workingYears = age - 18;
        int minJobs = Mathf.CeilToInt(workingYears / 12);
        int maxJobs = Mathf.CeilToInt(workingYears / 6);
        int numJobs = Random.Range(minJobs, maxJobs);
        return numJobs;
    }

    private string generateJob(Candidate candidate)
    {
        return JobsGenerator.generateJobForCandidate(candidate);
    }

    private string calculateDOB(Candidate candidate)
    {
        return (2016 - candidate.getAge()).ToString();
    }
}
