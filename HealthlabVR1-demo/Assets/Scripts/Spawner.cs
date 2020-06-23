using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 StartPosition;
    public Transform[] Spawnpoints;
    public GameObject[] Prefab;
    public GameObject[] PrefabClone;
    int i = 1;
    int iSphere = 1;


    // void Awake()
    //{
    //    StorePosition();
    //}


    //public void StorePosition()
    //{
    //    StartPosition = transform.position;
    //}


    public void spawnCubes(Collider other)
    {

        //StartPosition = transform.position;

        if (i <= 1)
        {
            PrefabClone[0] = Instantiate(Prefab[0], Spawnpoints[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[1] = Instantiate(Prefab[1], Spawnpoints[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[2] = Instantiate(Prefab[2], Spawnpoints[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[3] = Instantiate(Prefab[3], Spawnpoints[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[4] = Instantiate(Prefab[4], Spawnpoints[4].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[5] = Instantiate(Prefab[5], Spawnpoints[5].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

            i++;
        }
        else if (i <= 2)
        {
            Destroy(GameObject.FindWithTag("OrangeCube"));
            Destroy(GameObject.FindWithTag("GreenCube"));
            Destroy(GameObject.FindWithTag("RedCube"));
            Destroy(GameObject.FindWithTag("RectangleOrange"));
            Destroy(GameObject.FindWithTag("RectangleRed"));
            Destroy(GameObject.FindWithTag("RectangleGreen"));



            i--;
        }
       
    }
    public void spawnSpheres(Collider other)
    {

        //StartPosition = transform.position;

        if (iSphere <= 1)
        {
            PrefabClone[0] = Instantiate(Prefab[0], Spawnpoints[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[1] = Instantiate(Prefab[1], Spawnpoints[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[2] = Instantiate(Prefab[2], Spawnpoints[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[3] = Instantiate(Prefab[3], Spawnpoints[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

            iSphere++;
        }
        else if (iSphere <= 2)
        {
            Destroy(GameObject.FindWithTag("ThrowableSphere"));
            //Destroy(GameObject.FindWithTag("OrangeCube"));
            //Destroy(GameObject.FindWithTag("GreenCube"));
            //Destroy(GameObject.FindWithTag("RedCube"));


            iSphere--;
        }

    }

    //public void Respawn(Collider collider)
    //{
    //    if (GameObject.FindWithTag("OrangeCube"))
    //    {
    //        Debug.Log("Tagi toimii!");
    //         transform.position = StartPosition;
    //    }
    //}
}
