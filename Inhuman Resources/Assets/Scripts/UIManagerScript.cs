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

public class TestJob {

    public string title;
    public string text;

    public TestJob(string ti, string te) {
        title = ti;
        text = te;
    }

}

public class UIManagerScript : MonoBehaviour {

    private int currentCV;
    private List<TestCV> cvList;
    private TestJob job;
    private CanvasRenderer renderedCV;
    private CanvasRenderer renderedJob;
    private CanvasRenderer renderedContract;
    private bool jobshown;

    public CanvasRenderer cvPrefab;
    public CanvasRenderer jobPrefab;
    public CanvasRenderer contractPrefab;
    public Transform canvasTrans;

    public Button shownJobBtn; //Dirty! You should do this properly!

	// Use this for initialization
	void Start () {
        cvList = new List<TestCV>();
        cvList.Add(new TestCV("Geoff Gefferson", "My names geoff and I like cats"));
        cvList.Add(new TestCV("Sam McSamual", "I'm sam and I really hate cats"));
        cvList.Add(new TestCV("Lucy Lucyyyyyy", "I'm Lucy and I could take or leave cats"));
        cvList.Add(new TestCV("Rachel von Rachel", "My names Rachel and I don't know what a cat is"));
        
        currentCV = 0;

        job = new TestJob("Junior Cultist (applied frogs department)", "We need a candidate with a passion for subservience and minimal initiative. Enjoyment of frogs optional");

        renderCV();
        showJob();
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

    public void btnShowJob(){
        Debug.Log("JOB CLICKED");

        if (jobshown)
        {
            hideJob();
        }
        else {
            showJob();
        }
    }

    public void btnAccept() {
        Debug.Log("ACCEPT CLICKED");

        acceptCurrentCandidate();
    }

    public void btnNextJob()
    {
        Debug.Log("NEXT JOB CLICKED");

        startNextJob();
    }

    public void renderCV() {
        renderedCV = Instantiate(cvPrefab);
        renderedCV.gameObject.transform.SetParent(canvasTrans, false);
        renderedCV.GetComponentInChildren<Text>().text = cvList[currentCV].name+" \n\n "+ cvList[currentCV].text;

        Button accept = renderedCV.GetComponentInChildren<Button>();
        accept.onClick.AddListener(() => btnAccept());
    }

    public void destroyCV() {
        Destroy(renderedCV.gameObject);
    }

    public void showJob()
    {
        jobshown = true;
        shownJobBtn.GetComponentInChildren<Text>().text = "Hide Job";

        renderedJob = Instantiate(jobPrefab);
        renderedJob.gameObject.transform.SetParent(canvasTrans, false);
        renderedJob.GetComponentInChildren<Text>().text = job.title + " \n\n " + job.text;
    }

    public void hideJob()
    {
        jobshown = false;
        shownJobBtn.GetComponentInChildren<Text>().text = "Show Job";
        Destroy(renderedJob.gameObject);
    }


    public void acceptCurrentCandidate() {
        renderedContract = Instantiate(contractPrefab);
        renderedContract.gameObject.transform.SetParent(canvasTrans, false);
        renderedContract.GetComponentInChildren<Text>().text = "Contract for "+job.title + " \n\n " + "New Hire: "+cvList[currentCV].name+"\n\n Suitability for Job: F- \n Review: New hire is rubbish with frogs";

        Button accept = renderedContract.GetComponentInChildren<Button>();
        accept.onClick.AddListener(() => btnNextJob());

    }

    public void startNextJob() {

    }

    
}
