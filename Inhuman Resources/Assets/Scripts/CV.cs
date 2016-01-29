using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CV : MonoBehaviour {

    // Class which represents the CV of a given candidate

    public Candidate candidate = new Candidate();

    Text objectText;
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

    public void Awake()
    {
        this.cvText = "This is a CV!  Honest!";
        objectText = GetComponent<Text>();
        objectText.text = this.cvText;
    }







}
