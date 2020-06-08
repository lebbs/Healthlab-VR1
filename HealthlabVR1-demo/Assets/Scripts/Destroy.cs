using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    Vector3 startPosition;

     void Start()
    {
        startPosition = transform.position;
    }

    public void RespawnObject()
    {

        if (GameObject.FindWithTag("OrangeCube"))
        {
            transform.position = startPosition;
        }

    }

}
