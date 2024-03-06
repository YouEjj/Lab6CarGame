using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRedCar : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float moveSpeed = 15f;
    public float rotationSpeed = 5.0f;
    private int score = 0;
    private bool isMoving = false;
    private float timer = 0f;
    private float moveDuration = 5f;
    private bool isSlowed = false;
    private float slowTimer = 0f;
    private float slowDuration = 0.5f;


    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        /*if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }*/

        //Debug.Log("test");
        //Nitro
        if (score >= 4 && Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = true;
            timer = 0f;
            score -= 4;
        }

        if (isMoving)
        {
            transform.Translate(Vector3.forward * 20f * Time.deltaTime);
            timer += Time.deltaTime;

            if (timer >= moveDuration)
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                isMoving = false;
            }
            
        }


        if (isSlowed)
        {
            slowTimer += Time.deltaTime;
            if (slowTimer >= slowDuration)
            {
                moveSpeed = 15f;
                isSlowed = false;
                slowTimer = 0f;
            }
        }

    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            moveSpeed /= 2f;
            isSlowed = true;
            Debug.Log("Vitesse réduite: " + moveSpeed);
            score--;
            Debug.Log("Score: " + score);
            
        }

        if (collision.gameObject.tag == "coin")
        {
            score++;
            Debug.Log("Score: " + score);
        }
        if (collision.gameObject.tag == "bluecar")
        {
            score=score-2;
            Debug.Log("Score: " + score);
        }

        if (collision.gameObject.tag == "tro")
        {
            score = score - 2;
            Debug.Log("Score: " + score);
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        StartCoroutine(DelayedTransformation(collision));
    }

    private IEnumerator DelayedTransformation(Collision collision)
    {
        if (collision.gameObject.CompareTag("route"))
        {
            Debug.Log("ejecter");
            score = 0;
            Debug.Log("Score: " + score);

            yield return new WaitForSeconds(1f);

            transform.position = new Vector3(3.36f, 0.00115186f, transform.position.z);
            transform.rotation = Quaternion.identity;
        }


    }
    
}
