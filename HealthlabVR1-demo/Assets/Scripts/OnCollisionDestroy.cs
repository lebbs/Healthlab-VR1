using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CerealBox" || collision.gameObject.tag == "BeerBottle" 
            || collision.gameObject.tag == "EnergyDrink" 
            || collision.gameObject.tag == "JuiceCan" 
            || collision.gameObject.tag == "MilkCan")
        {
            Destroy(collision.gameObject);
        }
    }
}
