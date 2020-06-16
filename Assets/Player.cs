using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 playerLocation;
    private Vector3 move;
    private Vector3 left;
    private Vector3 right;
    private bool leftTF;
    private bool rightTF;
    private bool middleTF;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector3(0f, 0f, 1f);
        left = new Vector3(-3f, 0f, 0f);
        right = new Vector3(3f, 0f, 0f);
        middleTF = true;
        leftTF = false;
        rightTF = false;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(move * Time.deltaTime * 20);

        if (Input.GetKeyDown("left") && middleTF)
        {
            transform.Translate(left);
            leftTF = true;
            middleTF = false;
        }
        else if (Input.GetKeyDown("right") && middleTF)
        {
            transform.Translate(right);
            rightTF = true;
            middleTF = false;
        }
        else if (Input.GetKeyDown("right") && leftTF)
        {
            transform.Translate(right);
            rightTF = false;
            middleTF = true;
            leftTF = false;
        }
        else if (Input.GetKeyDown("left") && rightTF)
        {
            transform.Translate(left);
            rightTF = false;
            middleTF = true;
            leftTF = false;
        }
    }

    void DamagePlayer()
    {
        health--;
    }
}
