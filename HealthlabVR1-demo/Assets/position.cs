using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{

    Vector3 OriginalPosition;
    void Start()
    {
        OriginalPosition = transform.position;
    }

    public void Respawn()
    {

        if((transform.position - OriginalPosition).magnitude > 0.5f) {
            transform.position = OriginalPosition;

        }
    }
}
