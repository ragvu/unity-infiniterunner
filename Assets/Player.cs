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
    private bool middle1TF;
    private bool middle2TF;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector3(0f, 0f, 1f);
        left = new Vector3(-2f, 0f, 0f);
        right = new Vector3(2f, 0f, 0f);
        middle1TF = true;
        middle2TF=false;
        leftTF = false;
        rightTF = false;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(move * Time.deltaTime * 20);

        if (Input.GetKeyDown("left") && middle1TF)
        {
            transform.Translate(left);
            leftTF = true;
            middle1TF = false;
        }
        else if (Input.GetKeyDown("left") && middle2TF)
        {
            transform.Translate(left);
            middle2TF=false;
            middle1TF = true;
        }
        else if (Input.GetKeyDown("right") && middle2TF)
        {
            transform.Translate(right);
            rightTF = true;
            middle2TF = false;
        }
        else if (Input.GetKeyDown("right") && middle1TF)
        {
            transform.Translate(right);
            middle2TF = true;
            middle1TF = false;
        }
        else if (Input.GetKeyDown("right") && leftTF)
        {
            transform.Translate(right);
            rightTF = false;
            middle1TF = true;
            leftTF = false;
        }
        else if (Input.GetKeyDown("left") && rightTF)
        {
            transform.Translate(left);
            rightTF = false;
            middle2TF = true;
            leftTF = false;
        }
    }

    void DamagePlayer()
    {
        health--;
    }
}
