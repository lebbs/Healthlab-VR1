using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCheckOrange : MonoBehaviour
{
    // Start is called before the first frame update
    //Punainen palikka
    public GameObject UiObjectRight;
    public GameObject UiObjectWrong;
    public GameObject Trigger;

    ////Vihreä palikka
    //public GameObject UiObjectRight1;
    //public GameObject UiObjectWrong1;
    //public GameObject Trigger1;

    ////Oranssi palikka
    //public GameObject UiObjectRight2;
    //public GameObject UiObjectWrong2;
    //public GameObject Trigger2;

    private void Start()
    {
        UiObjectRight.SetActive(false);
        UiObjectWrong.SetActive(false);


        //UiObjectRight1.SetActive(false);
        //UiObjectWrong1.SetActive(false);

        //UiObjectRight2.SetActive(false);
        //UiObjectWrong2.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {

        StartCoroutine(ShowAndHide(UiObjectRight, 1.0f));
        //StartCoroutine(ShowAndHide(UiObjectWrong, 1.0f));

        if (other.tag == "OrangeCube")
        {
            UiObjectRight.SetActive(true);

        }
        else
        {
            UiObjectRight.SetActive(false);
            UiObjectWrong.SetActive(true);
        }
        //if (other.tag == "GreenCube")
        //{
        //    UiObjectRight.SetActive(true);
        //}
        //else
        //{
        //    UiObjectWrong.SetActive(true);
        //}

        //if (other.tag == "OrangeCube")
        //{
        //    UiObjectRight.SetActive(true);
        //}
        //else
        //{
        //    UiObjectWrong.SetActive(true);
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
        UiObjectRight.SetActive(false);
        UiObjectWrong.SetActive(false);

        //UiObjectRight1.SetActive(false);
        //UiObjectWrong1.SetActive(false);

        //UiObjectRight2.SetActive(false);
        //UiObjectWrong2.SetActive(false);
    }
}


