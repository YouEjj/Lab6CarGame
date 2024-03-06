using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class duplicateroad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject plan;
    public GameObject cube;
    public GameObject cube1;
    public GameObject coin;
    public GameObject trocom;
    public Transform carPos;
    public bool stop = false;
    public float z= 70f;
    public float pos = 35f;

    
    // Update is called once per frame
    void Update()
    {
        if (carPos.position.z >= pos)
        {
            

            Instantiate(plan, new Vector3(0, 0, z), Quaternion.identity);
            Instantiate(trocom, new Vector3(trocom.transform.position.x, trocom.transform.position.y, z), Quaternion.identity);
            
            for (int i = 0;i < 1;i++)
            {
                float x = Random.Range(-5.69f, 3.35f);
                float awez = Random.Range(z, z + 20f);
                Instantiate(cube, new Vector3(x, 0.5f, awez), Quaternion.identity);
            }
            for (int i = 0; i < 1; i++)
            {
                float x = Random.Range(-5.69f, 3.35f);
                float awez = Random.Range(z, z + 20f);
                Instantiate(cube1, new Vector3(x, 0.5f, awez), Quaternion.identity);
            }
            for (int i = 0; i < 2; i++)
            {
                float x = Random.Range(-5.69f, 3.35f);
                float awez = Random.Range(z, z + 30f);
                Instantiate(coin, new Vector3(x, 0.5f, awez), coin.transform.rotation);
            }
            //Debug.Log("Now !!!!!!!!!!!!!!");
            z += 40f;
            pos += 40f;
            
        }
        
    }
}
