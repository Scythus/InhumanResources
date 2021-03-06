﻿using UnityEngine;
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
            "Junior Cultist (Thuggery and Intimidation division)",
            "We need a new cultist for standing outside the ritual chamber looking surly. The ideal candidate will have a strong capacity for beating up private investigators, and experience in 'the murderous arts'. The candidate should also take direction well, and be of 'flexible morale character'."
            ));

        jobList.Add(new Job(
            2.0f,
            0.0f,
            -1.0f,
            -1.0f,
            -1.0f,
            0.0f,
            "Junior Cultist (Thaumaturgy and Eldritch Lore department)",
            "There is an opening in the library for a junior cultist capable of reading eldritch tomes, researching new rituals, and blowing up a minimum number of fellow cultists. The idea candidate will be academically minded with prior experience of mind bending literature and holding candles. As with all junior positions the candidate will expressly not think for themselves and will leave grand designs to the head priest or a cosmic deity from beyond the stars (project dependant). The chief thaumaturge also requests that a calm demeanour, a scrawny build, and a pallid complexion is desirable in order to maintain the ambience of the library."
            ));

        jobList.Add(new Job(
            0.0f,
            0.0f,
            -1.0f,
            3.0f,
            1.0f,
            -2.0f,
            "Junior Cultist (Street Corner Shouting and Public Flagellation class)",
            "After 'Mad' Larry’s encounter with the great beyond last week we have an opening in our world leading 'frothing lunatic cell'. The ideal candidate will possess an enthusiastic approach to shouting that would shame even a drill sergeant. Naturally limited psychiatric integrity will assist in this task. The public flagellation necessary for this position means the candidate will also have the strength and personal constitution to endure hours of whipping and occasional self-immolation. Finally, the junior aspect of this role demands a certain degree in grovelling (masters in grovelling a bonus)."
            ));

        jobList.Add(new Job(
            0.0f,
            2.0f,
            0.0f,
            0.0f,
            0.0f,
            1.0f,
            "Human Sacrifice",
            "We have gap in our monthly offering to the thing that lurks in the darkness after one of our virgins managed to escape. As such we are looking for a Human Sacrifice candidate that can bring a degree of purity and high morale standing to our great offering. Delicate individuals with minds yet undamaged by the horrors of the great truth are preferred so that we can bring some authenticity to the blood curdling screams that are the foundation of this role."
            ));

        jobList.Add(new Job(
            1.0f,
            -1.0f,
            3.0f,
            0.0f,
            0.0f,
            -1.0f,
            "Great Hierophant of The Terror With Many Faces",
            "We have an exciting opportunity for a devout servant of the great terror to progress to this senior role. The role will involve regular sermons to our assembled masses, leading monthly sacrifices, and light project management duties. The ideal candidate will demonstrate great ambition and ruthlessness in achieving the whims of the great terror. The position demands an individual that can display creativity and innovation in their single minded pursuit of eventual godhood at our master’s side. Experienced applicants (with the mental scars to prove it) only."
            ));

        jobList.Add(new Job(
            -2.0f,
            1.0f,
            0.0f,
            1.0f,
            0.0f,
            0.0f,
            "Cult Scapegoat",
            "After last week’s strategy meeting a position has been raised for a cult scapegoat. This role will provide us with someone to blame for the various disappearances, explosions, and chorused wailings that happen as a result of our regular activities. The ideal candidate will be of low intelligence to reduce the chances of an undesirable successful defence in court. Other advantageous qualities include an excitable nature to increase the plausibility of explosion allegations, and (as part of our ‘take back society from the do gooders’ initiative) a position as a morally upstanding member of society."
            ));

        jobList.Add(new Job(
            1.0f,
            0.0f,
            1.0f,
            -1.0f,
            -1.0f,
            0.0f,
            "Senior Cultist (Applied Frogs and Eye of Newt department)",
            "Recent expansion in our Black Swamps office means we have an opening in our historical potion focussed team for an experienced witch or warlock. The ideal candidate will be a go-getter keen on progressing to the highest levels of alchemy and poison development with natural academic aptitude. A calm and steady hand is needed for handling the more explosive compounds, and the high witch has requested a candidate more senior in their years for this role. A limp, warts, and cackling is a plus. "
            ));

        jobList.Add(new Job(
            0.0f,
            -1.0f,
            0.0f,
            -1.0f,
            1.0f,
            1.0f,
            "Cult Assassin",
            "In our day to day business of human sacrifice and connecting with eldritch terrors from beyond space and time we encounter a number of testing challenges. These are often human in nature from politicians, to investigators, to law enforcement - all with their own complaints about so called 'murder' and 'the end of humanity'. We have an opening for a talented trouble-shooter for these problems - literally in the sense that they will shoot the trouble. The ideal candidate should be fit and healthy, well trained in 'the murderous arts', and willing to compromise over any morality based inhibitions they might have. Other desirable skills are a clear mind yet unspoiled by death and destruction (our research shows gibbering madly reduces stealth), and a calm, relaxed, demeanour able to hold a sniper rifle steady."
            ));

        jobList.Add(new Job(
            -2.0f,
            0.0f,
            -2.0f,
            0.0f,
            -3.0f,
            0.0f,
            "Slave Intern",
            "We have an entry level opening for someone with very little ambition, no self-respect, and serious need for strong (forceful even) direction in their life. Duties include fanning the high priest, mopping up the sacrificial alter, and cowering at arcane terrors. The ideal candidate will be as weak and scrawny as possible (to prevent later resistance when they realise what the job entails), along with minimal personal drive and intelligence (to reduce escape attempts)."
            ));

        jobList.Add(new Job(
            2.0f,
            -1.0f,
            2.0f,
            -1.0f,
            0.0f,
            1.0f,
            "Senior Cultist (Scheming, Corruption, and Litigious Arts)",
            "A new Senior post has opened up due to internal promotion of the previous holder. We are very proud of 'Dark Puppet Masters' task force here at the cult of infinite darkness, and only the best candidate will do for this important role. Responsibilities include bribing politicians and law enforcement, representing senior cultists in court, Machiavellian scheming, and making allegations of 'blood magic' disappear. The ideal candidate will be academically minded, and with a strong personal drive to go straight to the top. It’s also important that the candidate have a moral code broad enough to include 'murder', 'extortion', and 'world domination'. Finally, as this person will often represent us in high society we wish to keep screaming in tongues and furious raving to a minimum."
            ));


            for (int i = 0; i < jobList.Count; i++)
            {
                Job temp = jobList[i];
                int randomIndex = Random.Range(i, jobList.Count);
                jobList[i] = jobList[randomIndex];
                jobList[randomIndex] = temp;
            }

            List<Job> jobSelection = new List<Job>();

            for (int i = 0; i < 5; i++) {
                jobSelection.Add(jobList[i]);
            }


        return jobSelection;
    }

}
