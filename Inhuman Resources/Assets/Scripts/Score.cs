using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Score {

    public float intelScore, moralityScore, ambitionScore, fervorScore, physiqueScore, sanityScore, scoreSum, normalisedScore;
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
        score += "Candidate Suitability Score: " + scoreSum + "\n\n\n";
        score += "Intelligence: " + intelScore + "\n";
        score += "Morality: " + moralityScore + "\n";
        score += "Ambition: " + ambitionScore + "\n";
        score += "Fervor: " + fervorScore + "\n";
        score += "Physique: " + physiqueScore + "\n";
        score += "Sanity: " + sanityScore + "\n";

        return score;

    }

    public string getNormalisedScoreBreakdown(List<CV> cvList)
    {
        calculateNormalisedScore(cv, job, cvList);

        string score = "";
        score += "Candidate Suitability Score: " + normalisedScore + "%\n\n";

        score += "Candidate Placement Feedback:\n";
        score += getFeedback("Intelligence", job.intWeighting, intelScore);
        score += getFeedback("Morality", job.morWeighting, moralityScore);
        score += getFeedback("Ambition", job.ambWeighting, ambitionScore);
        score += getFeedback("Fervor", job.ferWeighting, fervorScore);
        score += getFeedback("Physique", job.phyWeighting, physiqueScore);
        score += getFeedback("Sanity", job.sanWeighting, sanityScore);



        score += "\nThe Cult Oracle Says:\n";
        if (normalisedScore == 100.0f)
            score += "This was the best candidate available - the dark one smiles upon you!\n\n";
        else if (normalisedScore == 0.0f)
            score += "This was the worst candidate available - have you considered a career transfer to the sacrifices department?\n\n";
        else if (normalisedScore > 50.0f)
            score += "There were better candidates available, but the high priest is satisfied.\n\n";
        else if (normalisedScore < 50.0f)
            score += "There were worse candidates, but the high priest is displeased with this candidates poor performance.\n\n";

        /*score += "Sum: " + scoreSum + "\n";
        score += "Intelligence: " + intelScore + "\n";
        score += "Morality: " + moralityScore + "\n";
        score += "Ambition: " + ambitionScore + "\n";
        score += "Fervor: " + fervorScore + "\n";
        score += "Physique: " + physiqueScore + "\n";
        score += "Sanity: " + sanityScore + "\n";*/

        return score;

    }

    public string getFeedback(string stat, float weight, float score) {
        string feedback = "";

        if (weight != 0.0f && score != 0.0f)
        {
            string baddiff = "";
            string gooddiff = "";
            if (weight > 0)
            {
                baddiff = "low";
                gooddiff = "high";
            }
            else if (weight < 0)
            {
                baddiff = "high";
                gooddiff = "low";
            }

            if (score < -20)
            {
                feedback += "The candidates "+stat+" was far too "+baddiff+" for this job.\n";
            }
            else if (score < 0)
            {
                feedback += "The candidates " + stat + " was too " + baddiff + " for this job.\n";
            }
            else if (score > 20)
            {
                feedback += "The candidates " + gooddiff + " " + stat + " helped for this job.\n";
            }
            else if (score > 0)
            {
                feedback += "The candidates " + gooddiff + " " + stat + " was excellent for this job.\n";
            }
        }
        

        return feedback;
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
        fervorScore = calcIndividualScore(fervor, job.ferWeighting);

        // Calculate morality score
        int morality = candidate.getStat("morality");
        moralityScore = calcIndividualScore(morality, job.morWeighting);

        // Calculate ambition score
        int ambition = candidate.getStat("ambition");
        ambitionScore = calcIndividualScore(ambition, job.ambWeighting);

        // Calculate physique score
        int physique = candidate.getStat("physique");
        physiqueScore = calcIndividualScore(physique, job.phyWeighting);

        // Calculate sanity score
        int sanity = candidate.getStat("sanity");
        sanityScore = calcIndividualScore(sanity, job.sanWeighting);

        scoreSum = intelScore + moralityScore + ambitionScore + fervorScore + physiqueScore + sanityScore;

    }

    public void calculateNormalisedScore(CV cv, Job job, List<CV> cvList)
    {
        float lowest=1800.0f, highest=-1800.0f;
        
        foreach(CV c in cvList) {
            calculateScore(c, job);
            float tempScore = scoreSum;
            if (tempScore < lowest)
                lowest = tempScore;
            if (tempScore > highest)
                highest = tempScore;
            Debug.Log("Score: " + scoreSum);

        }
        Debug.Log("High: " + highest + " Low: " + lowest);

        calculateScore(cv, job);

        normalisedScore = Mathf.Round((scoreSum - lowest) * (100 / (highest - lowest)));

    }

    private static float calcIndividualScore(int candValue, float weight)
    {
        return ((candValue - 50) * weight);
    }
}
