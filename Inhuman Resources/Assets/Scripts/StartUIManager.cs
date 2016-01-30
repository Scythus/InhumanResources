using UnityEngine;
using System.Collections;

public class StartUIManager : MonoBehaviour {

    public void startGame() {
        Debug.Log("Starting Game");
        Application.LoadLevel("Introduction");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
