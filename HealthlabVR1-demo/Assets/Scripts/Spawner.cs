using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] Spawnpoints;
    public GameObject[] Prefab;
    public GameObject[] PrefabClone;
    int i = 1;

   public void spawn(Collider other)
    {

        if (i <= 1)
        {
            PrefabClone[0] = Instantiate(Prefab[0], Spawnpoints[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[1] = Instantiate(Prefab[1], Spawnpoints[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            PrefabClone[2] = Instantiate(Prefab[2], Spawnpoints[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

            i++;
        }
        else
        {

        } 
    }

}
