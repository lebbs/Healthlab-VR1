using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiObject;
    public GameObject Trigger;

    private void Start()
    {
        UiObject.SetActive(false);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="RedCube")
        {
            UiObject.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
    }
}
