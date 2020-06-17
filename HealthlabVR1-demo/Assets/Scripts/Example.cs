using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("point");
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        print(currentPoint.name);
    }
}
