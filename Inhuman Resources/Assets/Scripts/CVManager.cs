using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CVManager : MonoBehaviour {

    public CanvasRenderer cvPrefab;

    CV cv;

	// Use this for initialization
	void Start () {
        Candidate candidate = new Candidate();
        CVGenerator cvGen = new CVGenerator();
        cv = cvGen.generateCV(candidate);

        Debug.Log(cv.getCVText());


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
