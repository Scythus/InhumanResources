using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManagerScript : MonoBehaviour {

    private int currentCV;
    private int currentJob;
    private List<CV> cvList;
    private Job job;
    private CanvasRenderer renderedCV;
    private CanvasRenderer renderedJob;
    private CanvasRenderer renderedContract;
    private bool jobshown;

    private List<Job> jobs;
 

    public CanvasRenderer cvPrefab;
    public CanvasRenderer jobPrefab;
    public CanvasRenderer contractPrefab;
    public CanvasRenderer HUD;
    public Transform canvasTrans;

    // Sounds
    public AudioSource pageTurn;
    public AudioSource stamp;

    public Button shownJobBtn; //Dirty! You should do this properly!

    // Use this for initialization
    void Start() {
        startGame();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void startGame() {
        TotalScore.totalScore = 0.0f;

        jobs = new JobBank().getJobList();

        
        currentJob = 0;
        nextLevel();
    }

    public void nextLevel()
    {
        
        if(currentJob>=jobs.Count){
            Application.LoadLevel("End");
        }
        else{
       
            job = jobs[currentJob];

            CVGenerator cvGenerator = new CVGenerator();

            cvList = new List<CV>();
            int numberOfCVs = Random.Range(4, 7);
            for (int num = 0; num < numberOfCVs; num++)
            {
                Candidate candidate = new Candidate();
                cvList.Add(cvGenerator.generateCV(candidate));
            }

            currentCV = 0;

            renderCV();
            showJob();
            refreshHUD();
        }
    }

    public void btnNext() {
        Debug.Log("NEXT CLICKED");
        if (currentCV < cvList.Count - 1) {
            currentCV++;
            pageTurn.Play();
        }
        refreshHUD();
        destroyCV();
        renderCV();
    }

    public void btnPrev()
    {
        Debug.Log("PREV CLICKED");
        if (currentCV > 0)
        {
            currentCV--;
            pageTurn.Play();
        }
        refreshHUD();
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
        renderedJob.GetComponentInChildren<Text>().text = job.title + " \n\n " + job.description;
    }

    public void hideJob()
    {
        jobshown = false;
        shownJobBtn.GetComponentInChildren<Text>().text = "Show Job";
        Destroy(renderedJob.gameObject);
    }


    public void acceptCurrentCandidate() {
        Score scorer = new Score(cvList[currentCV], job);

        renderedContract = Instantiate(contractPrefab);
        renderedContract.gameObject.transform.SetParent(canvasTrans, false);
        renderedContract.GetComponentInChildren<Text>().text = "Contract for "+job.title + " \n\n " + "New Hire: "+cvList[currentCV].candidate.getName()+"\n\n"+ scorer.getNormalisedScoreBreakdown(cvList);

        TotalScore.totalScore += scorer.normalisedScore;
        refreshHUD();

        Button accept = renderedContract.GetComponentInChildren<Button>();
        accept.onClick.AddListener(() => btnNextJob());

        stamp.Play();
        StartCoroutine(waitAndDisplay(renderedContract.transform.Find("Hired").gameObject, 1.7f));

    }

    IEnumerator waitAndDisplay(GameObject gob, float time)
    {
        Text text = gob.GetComponent<Text>();
        yield return new WaitForSeconds(time);
        text.enabled = true;
        
    }

    public void destroyContract()
    {
        Destroy(renderedContract.gameObject);
    }

    public void startNextJob() {
        currentJob++;
        destroyCV();
        destroyContract();
        nextLevel();
    }

    public void refreshHUD() {
        HUD.GetComponent<Text>().text = "Vacancy: " + (currentJob + 1) + "/" + jobs.Count + "\nCandidate: " + (currentCV + 1) + "/" + cvList.Count + "\nScore: " + TotalScore.totalScore;
    }

    

}


