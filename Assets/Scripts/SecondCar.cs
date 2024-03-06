using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCar : MonoBehaviour
{
    // Start is called before the first frame update
    public float vitesseMin = 5f;
    public float vitesseMax = 10f;

    private float vitesseActuelle;


    void Start()
    {
        vitesseActuelle = Random.Range(vitesseMin, vitesseMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * vitesseActuelle * Time.deltaTime);
    }

   
}
