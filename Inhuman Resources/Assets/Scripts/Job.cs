using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Job {

    public float intWeighting, morWeighting, ambWeighting, ferWeighting, phyWeighting, sanWeighting;

    public string title;
    public string description;

    public Job(float i, float m, float a, float f, float p, float s, string t, string d) {
        intWeighting = i;
        morWeighting = m;
        ambWeighting = a;
        ferWeighting = f;
        phyWeighting = p;
        sanWeighting = s;
        title = t;
        description = d;
    }
}


public class JobBank
{

    public List<Job> getJobList()
    {
        List<Job> jobList = new List<Job>();

        jobList.Add(new Job(
            0.0f,
            -1.0f,
            -1.0f,
            0.0f,
            2.0f,
            0.0f,
            "Junior Cultist (thuggery and intimidation division)",
            "We need a new cultists for standing outside the ritual chamber looking surley. The ideal candidate will have a strong capacity for beating up private investigators, and experience in 'the murderous arts'. The candidate should also take direction well, and be of 'flexible morale character'."
            ));

        jobList.Add(new Job(
            2.0f,
            0.0f,
            -1.0f,
            -1.0f,
            -1.0f,
            0.0f,
            "Junior Cultist (Thaumaturgy and Eldrich Lore department)",
            "There is an opening in the library for a junior cultist capable of reading eldrich tomes, researching new rituals, and blowing up a minimum number of fellow cultists. The idea candidate will be academically minded with prior experience of mind bending literature and holding candles. As with all junior positions the candidate will expressly not think for themselves and will leave grand designs to the head priest or as cosmic diety from beyond the stars (project dependant). The chief thaumaturge also requests that a calm demeanour, a scrawny build, and a palid complextion is desirable in order to maintain the ambience of the library."
            ));

        jobList.Add(new Job(
            0.0f,
            0.0f,
            -1.0f,
            3.0f,
            1.0f,
            -2.0f,
            "Junior Cultist (Street Corner Shouting and Public Flagelation class)",
            "After 'Mad' Larrys encounter with the great beyond last week we have an opening in our world leading 'frothing lunatic cell'. The ideal candidate will possess an enthusiastic approach to shouting that would shame even a drill sargeant. Naturally limited psychiatric integrity will assist in this task. The public flagelation neacessary for this possition means the candidate will also have the strength and person consistution to endure hours of whipping and occasional self immolation. Finally the junior aspect of this role demands a certain degree in grovelling (masters in grovelling a bonus)."
            ));

        jobList.Add(new Job(
            0.0f,
            2.0f,
            0.0f,
            0.0f,
            0.0f,
            1.0f,
            "Human Sacrifice",
            "We have gap in our monthly offering to the thing that lurks in the darkness after one of our virgins managed to escape. As such we are looking for a Human Sacrifice candidate that can bring a degree of purity and high morale standing to our great offering. Delicate individuals with minds yet unravaged by the horrors of the great truth are preffered so that we can bring some authencity to the blood curdelling screams that are the foundation of this role."
            ));

        jobList.Add(new Job(
            1.0f,
            -1.0f,
            3.0f,
            0.0f,
            0.0f,
            -1.0f,
            "Hierophant of the terror with many faces",
            "We have an exciting opportunity for a devout servant of the great terror to progress to this senior role. The role will involve regular sermons to our assembled masses, leading monthly sacrifices, and light projects management duties. The ideal candidate will demonstrate great ambition and ruthlessness in achieving the whims of the great terror. The position demands an individual that can display creativity and innovation in their single minded pursuit of eventual godhood at our masters side. Experienced applicants (with the mental scars to prove it) only."
            ));

        jobList.Add(new Job(
            -2.0f,
            1.0f,
            0.0f,
            1.0f,
            0.0f,
            0.0f,
            "Cult Scapegoat",
            "After last weeks strategy meeting a position has been raised for a cult scapegoat. This role will provide us with someone to blame for the various disappearances, explosions, and chorused wailing that happens as a result of our regular activities. The ideal candidate will be of low intelligence to reduce the chances of an undesirable successful defence in court. Other advantageous qualities include an excitable nature to increase the plausibility of explosion alagations, and prior experience as an upstanding member of society (because if someone is going to prison, it might as well be them). "
            ));

        jobList.Add(new Job(
            1.0f,
            0.0f,
            1.0f,
            -1.0f,
            -1.0f,
            0.0f,
            "Senior Cultist (Applied Frogs and Eye of Newt department)",
            "Recent expansion in our Black Swamps office means we have an opening in our historical potion focussed team for an experienced witch or warlock. The ideal candidate will be a go-getter keen on progressing to the highest levels of alchemy and poison development with natual academic aptitude. A calm and steady hand is needed for handeling the more explosive compounds, and the high witch has requested a minimum age of 68 for this role. A limp, warts, and cackling is a plus. "
            ));

        /*jobList.Add(new Job(
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            "",
            ""
            ));

        jobList.Add(new Job(
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            "",
            ""
            ));

        jobList.Add(new Job(
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            "",
            ""
            ));

        jobList.Add(new Job(
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            0.0f,
            "",
            ""
            ));*/


        return jobList;
    }

}
