using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform carTransform;
    // Update is called once per frame
    void Update()
    {
        if (carTransform != null)
        {
            transform.position = new Vector3(carTransform.position.x, carTransform.position.y + 5f, carTransform.position.z - 12f);
        }
    }
}
