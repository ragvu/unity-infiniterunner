using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed = 1f;
    private float leftBound;
    private float rightBound;
    private bool goRight;
    private bool goLeft;
    private Vector3 leftSpeed;
    private Vector3 rightSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x > 7)
        {
            rightBound = transform.position.x;
            leftBound = transform.position.x - 10f;
        }
        else if (transform.position.x < 7)
        {
            leftBound = transform.position.x;
            rightBound = transform.position.x + 10f;
        }

        leftSpeed = new Vector3(-.05f,0f,0f);
        rightSpeed = new Vector3(.05f,0f,0f);

    }

    // Update is called once per frame
    void Update()
    {
        print(transform.position);
        if (transform.position.x <= leftBound)
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;
            transform.Translate(rightSpeed * Time.deltaTime * speed);
            goRight = true;
            goLeft = false;
        }
        else if (transform.position.x >= rightBound)
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;
            transform.Translate(leftSpeed * Time.deltaTime * speed);
            goLeft = true;
            goRight = false;
        }
        else
        {
            if (goRight == true)
            {
                //transform.position += Vector3.right * speed * Time.deltaTime;
                transform.Translate(rightSpeed * Time.deltaTime * speed);
            }
            else if (goLeft == true)
            {
                //transform.position += Vector3.left * speed * Time.deltaTime;
                transform.Translate(leftSpeed * Time.deltaTime * speed);
            }
        }
    }
}
