using UnityEngine;
using System.Collections;

public class EndUIManager : MonoBehaviour {

    public void endGame()
    {
        Application.LoadLevel("Start");
    }
}
