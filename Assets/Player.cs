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
    public Vector3 jump;
    public float jumpForce =100.0f;
    public bool isGrounded;
    public Rigidbody playerLocal;
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector3(0f, 0f, 1f);
        left = new Vector3(-3f, 0f, 0f);
        right = new Vector3(3f, 0f, 0f);
        middleTF = true;
        leftTF = false;
        rightTF = false;
        jump = new Vector3(0f, 5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(move * Time.deltaTime * 20);

        if (Input.GetKeyDown("left") && middleTF && isGrounded)
        {
            transform.position = Vector3.MoveTowards(transform.position, left, 20 * Time.deltaTime);
            //transform.Translate(left * Time.deltaTime * 20);
            leftTF = true;
            middleTF = false;
        }
        else if (Input.GetKeyDown("right") && middleTF && isGrounded)
        {
            transform.Translate(right);
            rightTF = true;
            middleTF = false;
        }
        else if (Input.GetKeyDown("right") && leftTF && isGrounded)
        {
            transform.Translate(right);
            rightTF = false;
            middleTF = true;
            leftTF = false;
        }
        else if (Input.GetKeyDown("left") && rightTF && isGrounded)
        {
            print("left from middle");
            transform.Translate(left);
            rightTF = false;
            middleTF = true;
            leftTF = false;
        }

        if (Input.GetKeyDown("space") && isGrounded)
        {
            print("jump");
            playerLocal.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }

    void DamagePlayer()
    {
        health--;
    }

    private void OnCollisionStay(Collision other)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }

}
