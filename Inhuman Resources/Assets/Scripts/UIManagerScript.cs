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
    private List<CV> cvList;
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
    void Start() {

        CVGenerator cvGenerator = new CVGenerator();


        cvList = new List<CV>();
        int numberOfCVs = Random.Range(4, 7);
        for (int num = 0; num < numberOfCVs; num++)
        {
            Candidate candidate = new Candidate();
            cvList.Add(cvGenerator.generateCV(candidate));
        }
        
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
        renderedCV.GetComponentInChildren<Text>().text = cvList[currentCV].candidate.getName()+" \n\n"+ cvList[currentCV].getCVText();

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
        renderedContract.GetComponentInChildren<Text>().text = "Contract for "+job.title + " \n\n " + "New Hire: "+cvList[currentCV].candidate.getName()+"\n\n Suitability for Job: F- \n Review: New hire is rubbish with frogs";

        Button accept = renderedContract.GetComponentInChildren<Button>();
        accept.onClick.AddListener(() => btnNextJob());

    }

    public void startNextJob() {

    }

    
}
