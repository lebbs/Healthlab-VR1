using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroceryTest : MonoBehaviour
{


    public List<GameObject> GroceryList = new List<GameObject>();
    int number;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject grocery in GameObject.FindGameObjectsWithTag("Grocery"))
        {
            GroceryList.Add(grocery);

            Debug.Log("Jeejee");
            Debug.Log(grocery);

            //Console.WriteLine(grocery);
        }

        StartSpawn();

    }

    public void StartSpawn()
    {
        for (int i = 0; i < GroceryList.Count; i++)
        {
            int itemIndex = Random.Range(0, GroceryList.Count);
            
        }


    }

    //public static List<T> GetRandomItemsFromList<T>(List<T> list, int number)
    //{
    //    List<T> tmpList = new List<T>(list);

    //    List<T> newList = new List<T>();

    //    while(newList.Count < number && tmpList.Count > 0)
    //    {
    //        int index = Random.Range(0, tmpList.Count);
    //        newList.Add(tmpList[index]);
    //        tmpList.RemoveAt(index);
    //    }
    //    Debug.Log(newList);

    //    return newList;


    }

    // Update is called once per frame
    

