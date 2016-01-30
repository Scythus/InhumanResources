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

        cvPrefab = (CanvasRenderer) Instantiate(cvPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        Text text = cvPrefab.transform.Find("CV_Text").GetComponent<Text>();
        
        cv.SetupCV(text);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
