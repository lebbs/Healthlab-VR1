using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroceryCheck : MonoBehaviour
{



    public GameObject Trigger;
    public GameObject Right;
    public GameObject Wrong;
    // Start is called before the first frame update
    void Start()
    {
        Right.SetActive(false);
        Wrong.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        StartCoroutine(ShowAndHide(Right, 1.0f));
        //StartCoroutine(ShowAndHide(Wrong, 1.0f));

        if (other.gameObject.tag == "JuiceCan" || other.gameObject.tag == "MilkCan" || other.gameObject.tag == "EnergyDrink")
        {
            Right.SetActive(true);

        }
        else 
        {
            Right.SetActive(false);
            Wrong.SetActive(true);
        }



        //if (other.tag == "MilkCan")
        //{
        //    Right.SetActive(true);
        //}

        //else
        //{
        //    Right.SetActive(false);
        //    Wrong.SetActive(true);
        //}

    }
    IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }




    private void OnTriggerExit(Collider other)
    {
        Right.SetActive(false);
        Wrong.SetActive(false);

        //UiObjectRight1.SetActive(false);
        //UiObjectWrong1.SetActive(false);

        //UiObjectRight2.SetActive(false);
        //UiObjectWrong2.SetActive(false);
    }
}
