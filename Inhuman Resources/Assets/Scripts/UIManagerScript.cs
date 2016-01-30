using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TestCV {
    public string name;
    public string text;

    public TestCV(string n, string t) {
        name = n;
        text = t;
    }
}

public class UIManagerScript : MonoBehaviour {

    private int currentCV;
    private List<TestCV> cvList;
    private CanvasRenderer renderedCV;

    public CanvasRenderer cvPrefab;
    public Transform canvasTrans;

	// Use this for initialization
	void Start () {
        cvList = new List<TestCV>();
        cvList.Add(new TestCV("Geoff Gefferson", "My names geoff and I like cats"));
        cvList.Add(new TestCV("Sam McSamual", "I'm sam and I really hate cats"));
        cvList.Add(new TestCV("Lucy Lucyyyyyy", "I'm Lucy and I could take or leave cats"));
        cvList.Add(new TestCV("Rachel von Rachel", "My names Rachel and I don't know what a cat is"));

        currentCV = 0;

        renderCV();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void btnNext() {
        Debug.Log("NEXT CLICKED");
        if (currentCV < cvList.Count - 1) {
            currentCV++;
        }
        destroyCV();
        renderCV();
    }

    public void btnPrev()
    {
        Debug.Log("PREV CLICKED");
        if (currentCV > 0)
        {
            currentCV--;
        }
        destroyCV();
        renderCV();
    }

    public void renderCV() {
        renderedCV = Instantiate(cvPrefab);
        renderedCV.gameObject.transform.SetParent(canvasTrans, false);
        renderedCV.GetComponentInChildren<Text>().text = cvList[currentCV].name+" \n\n "+ cvList[currentCV].text;
    }

    public void destroyCV() {
        Destroy(renderedCV.gameObject);
    } 
}
