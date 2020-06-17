using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour
{

    public GameObject Text;


    // Start is called before the first frame update
    void Start()
    {
       // showtext();
    }

    public void showtext()
    {
        StartCoroutine(ShowAndHide(Text, 3.0f));

        Text.SetActive(true);

    }


    IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }


}
