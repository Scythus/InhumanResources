using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CV  {

    // Class which represents the CV of a given candidate

    public Candidate candidate = new Candidate();

    string cvText;

    public CV(Candidate candidate, string cvContents)
    {

        this.candidate = candidate;

        // Generate a CV
        this.cvText = cvContents;
    }

    public Candidate getCandidate()
    {
        return this.candidate;
    }

    public void SetupCV(Text text)
    {
        text.text = this.cvText;
    }








}
