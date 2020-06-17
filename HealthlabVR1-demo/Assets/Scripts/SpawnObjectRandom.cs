using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectRandom : MonoBehaviour
{

    //Spawned objects
    public GameObject ObjectPrefab1, ObjectPrefab2, ObjectPrefab3, ObjectPrefab4, ObjectPrefab5;

    int WhatToSpawn;

    //public GameObject ObjectPrefab1;

    public Vector3 Center;
    public Vector3 Size;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {

        Center = transform.position;
    
        //SpawnObject();
    }

    public void RandomSpawn()
    {
        while (i <= 10)
        {
            Vector3 pos = Center + new Vector3(Random.Range(-Size.x / 2, Size.x / 2), Random.Range(-Size.y / 2, Size.y / 2), Random.Range(-Size.z / 2, Size.z / 2));

            WhatToSpawn = Random.Range(1, 6);

            switch (WhatToSpawn)
            {
                case 1:


                    Instantiate(ObjectPrefab1, pos, Quaternion.identity);

                    break;

                case 2:

                    Instantiate(ObjectPrefab2, pos, Quaternion.identity);

                    break;

                case 3:

                    Instantiate(ObjectPrefab3, pos, Quaternion.identity);
                    break;

                case 4:

                    Instantiate(ObjectPrefab4, pos, Quaternion.identity);
                    break;

                case 5:

                    Instantiate(ObjectPrefab5, pos, Quaternion.identity);
                    break;


            }
            i++;
        }
    }


        //public void SpawnObject()
        //{
        //    Vector3 pos = Center + new Vector3(Random.Range(-Size.x / 2, Size.x/2), Random.Range(-Size.y / 2, Size.y / 2), Random.Range(-Size.z / 2, Size.z / 2));

        //    Instantiate(ObjectPrefab1, pos, Quaternion.identity);
        //   // Instantiate(ObjectPrefab1, pos, Quaternion.identity);

        //}


        private void OnDrawGizmosSelected()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            Gizmos.DrawCube(transform.localPosition + Center, Size);

        //Gizmos.color = new Color(2, 0, 0, 0.5f);
        //Gizmos.DrawCube(transform.localPosition + Center, Size);
    }
    
}
