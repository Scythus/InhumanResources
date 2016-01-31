using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CV  {

    // Class which represents the CV of a given candidate

    public Candidate candidate;

    string cvText;
    Sprite cvPic;

    public CV(Candidate candidate, string cvContents, Sprite cvPic)
    {

        this.candidate = candidate;

        // Generate a CV
        this.cvText = cvContents;
        this.cvPic = cvPic;
    }

    public Candidate getCandidate()
    {
        return this.candidate;
    }

    public Sprite getCVPic()
    {
        return cvPic;
    }

    public string getCVText()
    {
        return cvText;
    }

    public void SetupCV(Text text)
    {
        text.text = this.cvText;
    }








}
