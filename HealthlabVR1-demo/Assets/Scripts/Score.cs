﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ThrowableSphere")
        {
            theScore += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + theScore;
        }
        
    }

}
