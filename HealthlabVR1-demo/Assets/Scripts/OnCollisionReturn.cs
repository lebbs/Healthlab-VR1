using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionReturn : MonoBehaviour
{

    Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            gameObject.transform.position = originalPosition;
        }
    }

}
