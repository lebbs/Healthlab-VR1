using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grocery : MonoBehaviour
{

    public Color NewColor;
    public string NewString;
    public GameObject ostos1;
    public GameObject ostos2;
    public GameObject ostos3;

    //int i = 0;

    //int CheckGrocery;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {

        {


            {

                {
                    if (collision.gameObject.tag == "EnergyDrink")
                    {
                        ostos1.GetComponent<Renderer>().material.color = Color.green;
                    }
                    //else
                    //{
                    //    ostos1.GetComponent<Renderer>().material.color = Color.red;
                    //}



                    if (collision.gameObject.tag == "JuiceCan")
                    {
                        ostos2.GetComponent<Renderer>().material.color = Color.green;
                    }
                    //else
                    //{
                    //    ostos2.GetComponent<Renderer>().material.color = Color.green;
                    //}

                    if (collision.gameObject.tag == "BeerBottle")
                    {
                        ostos3.GetComponent<Renderer>().material.color = Color.green;
                    }
                    //else
                    //{
                    //    ostos2.GetComponent<Renderer>().material.color = Color.green;
                    //}
                }
                        

            }

            //if (collision.gameObject.tag == "EnergyDrink")
            //{
            //    ostos1.GetComponent<Renderer>().material.color = Color.green;

            //}
            //else
            //{
            //    ostos1.GetComponent<Renderer>().material.color = Color.red;

            //}

            // if (collision.gameObject.tag == "JuiceCan")
            //{
            //    ostos2.GetComponent<Renderer>().material.color = Color.green;

            //}
            //else
            //{
            //    ostos2.GetComponent<Renderer>().material.color = Color.red;

            //}



        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //ostos1.GetComponent<Renderer>().material.color = Color.red;
        //ostos2.GetComponent<Renderer>().material.color = Color.red;
        //ostos3.GetComponent<Renderer>().material.color = Color.red;


    }
}
