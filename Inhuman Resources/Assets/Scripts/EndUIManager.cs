using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EndUIManager : MonoBehaviour {

    public CanvasRenderer scoreText;

    public void Start() {
        float finalScore = TotalScore.totalScore;
        float averageScore = Mathf.Round(finalScore/new JobBank().getJobList().Count);

        scoreText.GetComponentInChildren<Text>().text = "Total Score: \n" + finalScore + "\n\n Average Score: \n " + averageScore+"\n\n\n"+getFeedback(averageScore);
    }

    public string getFeedback(float avgScore) {
        string feedback = "";
        if (avgScore < 25) {
            feedback += "Your appointments have been terrible. You have been reassigned to the role of slave intern - your new duties include cleaning the pit of unfathomable darkness, and backup human sacrifice.";
        }
        else if (avgScore < 50)
        {
            feedback += "Your appointments have been poor. You have been reassigned to Junior Cultist where you are doomed to work alongside the idiots you hired.";
        }
        else if (avgScore < 75)
        {
            feedback += "Your appointments are adequate. The high priest has allowed you to continue in your role as chief recruiter inexchange for a new contract promising a 1000 years of service.";
        }
        else if (avgScore < 90)
        {
            feedback += "Your appointments have been very satisfactory, and the high priest is pleased with you. You are promoted to the role of priest of tedious paper work which includes a bubbling cauldron, and the ghosts of a whole office of HR staff.";
        }
        else
        {
            feedback += "Your appointments have been excellent! So much so that Yaragh Vorl - he who files in the shadows - has taken notice. You are spirited away to his realm of endless paperwork where you may review CVs for his pleasure for eternity.";
        }

        return feedback;
    }

    public void endGame()
    {
        Application.LoadLevel("Start");
    }
}
