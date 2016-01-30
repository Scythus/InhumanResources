using UnityEngine;
using System.Collections;

public class Score {

    float intelScore, moralityScore, ambitionScore, fervorScore, physiqueScore, sanityScore;
    Job job;
    CV cv;

    public Score(CV cv, Job job)
    {
        this.cv = cv;
        this.job = job;
    }

    public string getScoreBreakdown()
    {
        calculateScore(cv, job);

        string score = "";
        score += "Intelligence: " + intelScore + "\n";
        score += "Morality: " + moralityScore + "\n";
        score += "Ambition: " + ambitionScore + "\n";
        score += "Fervor: " + fervorScore + "\n";
        score += "Physique: " + physiqueScore + "\n";
        score += "Sanity: " + sanityScore + "\n";

        return score;

    }

	public void calculateScore(CV cv, Job job)
    {
        
        // Get candidate from CV
        Candidate candidate = cv.getCandidate();

        // Calculate intelligence score
        int intel = candidate.getStat("intelligence");
        intelScore = calcIndividualScore(intel, job.intWeighting);

        // Calculate fervor score
        int fervor = candidate.getStat("fervor");
        fervorScore += calcIndividualScore(fervor, job.ferWeighting);

        // Calculate morality score
        int morality = candidate.getStat("morality");
        moralityScore += calcIndividualScore(morality, job.morWeighting);

        // Calculate ambition score
        int ambition = candidate.getStat("ambition");
        ambitionScore += calcIndividualScore(ambition, job.ambWeighting);

        // Calculate physique score
        int physique = candidate.getStat("physique");
        physiqueScore += calcIndividualScore(physique, job.phyWeighting);

        // Calculate sanity score
        int sanity = candidate.getStat("sanity");
        sanityScore += calcIndividualScore(sanity, job.sanWeighting);

    }

    private static float calcIndividualScore(int candValue, float weight)
    {
        return ((candValue - 50) * weight);
    }
}
