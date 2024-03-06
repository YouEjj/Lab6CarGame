using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bluecar")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "redcar")
        {
            Destroy(gameObject);
        }
    }
}
