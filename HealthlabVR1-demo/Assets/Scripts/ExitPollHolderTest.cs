using CognitiveVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPollHolderTest : MonoBehaviour
{
    // Start is called before the first frame update
    public ExitPollSet questionSet;

    public void QuestionSet()
    {
        CognitiveVR.ExitPoll.NewExitPoll("vr1_demo_complete").Begin();
         
    }

}
