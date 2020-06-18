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
    public GameObject ostostxt1;
    public GameObject ostostxt2;
    public GameObject ostostxt3;
    //public string NewString;
    //public GameObject[] ostoslista;


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
            || other.gameObject.tag == "BeerBottle"
            || other.gameObject.tag == "EnergyDrink")
        {
            
           
            Right.SetActive(true);
           
        }
        else 
        {
            Right.SetActive(false);
            Wrong.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnergyDrink")
        {
            ostostxt1.GetComponent<Renderer>().material.color = Color.green;
        }
        //else
        //{
        //    ostos1.GetComponent<Renderer>().material.color = Color.red;
        //}



        if (collision.gameObject.tag == "JuiceCan")
        {
            ostostxt2.GetComponent<Renderer>().material.color = Color.green;
        }
        //else
        //{
        //    ostos2.GetComponent<Renderer>().material.color = Color.green;
        //}

        if (collision.gameObject.tag == "BeerBottle")
        {
            ostostxt3.GetComponent<Renderer>().material.color = Color.green;
        }
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
