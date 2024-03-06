using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplan : MonoBehaviour
{

    public string carTag = "redcar";
    private float previousZ = 0f;

    void Start()
    {
        GameObject carObject = GameObject.FindWithTag(carTag);
        if (carObject != null)
        {
            previousZ = carObject.transform.position.z;
        }
    }

    void Update()
    {
        GameObject carObject = GameObject.FindWithTag(carTag);
        if (carObject != null && carObject.transform.position.z > previousZ + 70f)
        {
            Destroy(gameObject);

            GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

            
            foreach (GameObject cube in cubes)
            {
                if(carObject.transform.position.z + 10f > cube.transform.position.z)
                {
                    Destroy(cube);
                }
                
            }

            GameObject[] coins = GameObject.FindGameObjectsWithTag("coin");


            foreach (GameObject coin in coins)
            {
                if (carObject.transform.position.z + 10f > coin.transform.position.z)
                {
                    Destroy(coin);
                }

            }
            GameObject trot = GameObject.FindGameObjectWithTag("troglo");
            Destroy(trot);
                

           
        }
    }
}
