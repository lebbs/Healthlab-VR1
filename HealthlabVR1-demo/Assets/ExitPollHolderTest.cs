using CognitiveVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPollHolderTest : MonoBehaviour
{
    // Start is called before the first frame update
    public ExitPollSet questionSet;

    void Start()
    {
       CognitiveVR.ExitPoll.NewExitPoll("arvosana").Begin();
    }

    
}
