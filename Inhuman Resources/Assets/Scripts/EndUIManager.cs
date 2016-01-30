using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EndUIManager : MonoBehaviour {

    public CanvasRenderer scoreText;

    public void Start() {
        scoreText.GetComponentInChildren<Text>().text = "Total Score: \n"+TotalScore.totalScore;
    }

    public void endGame()
    {
        Application.LoadLevel("Start");
    }
}
