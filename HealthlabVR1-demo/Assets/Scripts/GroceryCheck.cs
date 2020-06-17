using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroceryCheck : MonoBehaviour
{



    public GameObject Trigger;
    public GameObject Right;
    public GameObject Wrong;
    public Color NewColor;
    public string NewString;
    public GameObject[] ostoslista;


   // public List<GameObject> GroceryList = new List<GameObject>();

    int i = 0;
    int WhatToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Right.SetActive(false);
        Wrong.SetActive(false);

        //foreach (GameObject grocery in GameObject.FindGameObjectsWithTag("Grocery"))
        //{
        //    GroceryList.Add(grocery);

        //    Debug.Log(grocery);
        //}

        //foreach(GameObject g in ostoslista)
        //{
        //    if (GameObject.FindGameObjectWithTag("Energydrink"))
        //    {
        //        g.GetComponent<Renderer>().material.color = NewColor;

        //    }
        //}
    }

    private void OnTriggerEnter(Collider other)
    {

        
        StartCoroutine(ShowAndHide(Right, 1.0f));
        //StartCoroutine(ShowAndHide(Wrong, 1.0f));

        if (other.gameObject.tag == "JuiceCan" 
            || other.gameObject.tag == "MilkCan"
            || other.gameObject.tag == "EnergyDrink")
        {
            
           
            Right.SetActive(true);
           
        }
        else 
        {
            Right.SetActive(false);
            Wrong.SetActive(true);
        }

       

        //while(i <= 4)
        // {
        //    WhatToSpawn = Random.Range(0, GroceryList.Count);

        //    switch (WhatToSpawn)
        //    {
        //        case 1:
        //    }

        // }


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
