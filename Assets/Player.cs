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
    public Vector3 jump;
    public float jumpForce = 100.0f;
    public bool isGrounded;
    public Rigidbody playerLocal;
    public GenerateObstacle generateObstacleScript;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

        generateObstacleScript = playerLocal.GetComponent<GenerateObstacle>();

        move = new Vector3(0f, 0f, 1f);
        left = new Vector3(-3f, 0f, 0f);
        right = new Vector3(3f, 0f, 0f);
        middle1TF = true;
        middle2TF = false;
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

        if (Input.GetKeyDown("left") && middle1TF && isGrounded)
        {
            //transform.position = Vector3.MoveTowards(transform.position, left, 20 * Time.deltaTime);
            transform.Translate(left);
            leftTF = true;
            middle1TF = false;
        }
        else if (Input.GetKeyDown("right") && middle2TF && isGrounded)
        {
            transform.Translate(right);
            rightTF = true;
            middle2TF = false;
        }
        else if (Input.GetKeyDown("right") && middle1TF && isGrounded)
        {
            transform.Translate(right);
            middle2TF = true;
            middle1TF = false;
        }
        else if (Input.GetKeyDown("right") && leftTF && isGrounded)
        {
            transform.Translate(right);
            rightTF = false;
            middle1TF = true;
            leftTF = false;
        }
        else if (Input.GetKeyDown("left") && rightTF && isGrounded)
        {
            
            transform.Translate(left);
            rightTF = false;
            middle2TF = true;
            leftTF = false;
        }
        else if (Input.GetKeyDown("left") && middle2TF && isGrounded)
        {

            transform.Translate(left);
            rightTF = false;
            middle2TF = false;
            leftTF = false;
            middle1TF = true;
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
        if (other.gameObject.tag == "Floor")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            isGrounded = false;
        }
    }

}
