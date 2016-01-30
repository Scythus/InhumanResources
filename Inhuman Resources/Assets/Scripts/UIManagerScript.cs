using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TestCV {
    public string name = "Geoff Geofferson";
    public string text = "This is a CV";
}

public class UIManagerScript : MonoBehaviour {

    private int currentCV;
    private List<TestCV> cvList;

    public CanvasRenderer cvPrefab;
    public Transform canvasTrans;

	// Use this for initialization
	void Start () {
        cvList = new List<TestCV>();
        cvList.Add(new TestCV());
        cvList.Add(new TestCV());
        cvList.Add(new TestCV());
        cvList.Add(new TestCV());

        currentCV = 0;

        renderCV();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void btnNext() {
        Debug.Log("NEXT CLICKED");
    }

    public void btnPrev()
    {
        Debug.Log("PREV CLICKED");
    }

    public void renderCV() {
        CanvasRenderer renderedCV = Instantiate(cvPrefab);
        renderedCV.gameObject.transform.SetParent(canvasTrans, false);
        renderedCV.GetComponentInChildren<Text>().text = cvList[currentCV].name+" \n\n "+ cvList[currentCV].text;
    } 
}
