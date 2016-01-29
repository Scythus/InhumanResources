using UnityEngine;
using System.Collections;

public class CVGenerator {

	public static void GenerateCV(Candidate candidate)
    {
        // Generate a CV object for a given candidate
    }

    private string makeJobHistory(Candidate candidate)
    {
        // Get the job history for a candidate
        return "This candidate has had " + calculateNumberOfJobs(candidate.getAge());
    }



    // Calculates the number of jobs held
    // Assumes that jobs lasted at least 2 years, and no more than 12 years
    private int calculateNumberOfJobs(int age)
    {
        int workingYears = age - 18;
        int minJobs = Mathf.CeilToInt(workingYears / 12);
        int maxJobs = Mathf.CeilToInt(workingYears / 2);
        int numJobs = Random.Range(minJobs, maxJobs);
        return numJobs;
    }
}
