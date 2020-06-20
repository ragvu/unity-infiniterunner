using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Sphere3;
    public GameObject Sphere4;
    private GameObject playerLocal;
    private Player playerScript;
    public GameObject obstacleLocal;
    public Rigidbody obstacle;
    private DamagePickup obstacleScript;
    public float zSpawn;
    public float[] xSpawnA;
    private float playerX;
    private float xSpawn;
    private int playerhealth;
    private int score;
    private int typeOfObstacle;
    // private int obstacleType;
    private Vector3 obstacleSpawn;
    private Vector3 SphereSpawn;
    // Start is called before the first frame update
    public bool fireObstacleSet = false;
    public bool waterObstacleSet = false;
    public bool earthObstacleSet = false;
    private bool airObstacleSet = false;
    public bool fireElem = false;
    public bool waterElem = false;
    public bool earthElem = false;
    public bool airElem = false;
    void Start()
    {
        obstacleLocal = GameObject.Find("Obstacle");
        playerX = this.transform.transform.position.x + 1.5f;
        xSpawnA = new float[] { playerX - 4.5f, playerX - 1.5f, playerX + 1.5f, playerX + 4.5f};
        print(xSpawnA[0]);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void generateObstacle()
    {
        // int obstacleType = Random.Range(0, 3);
        // print ("Random number is " + obstacleType);
        //  var random = new Random();

        // var list = new List<string>{ "one", "two", "three", "four"};
        // int index = random.Next(list.Count);
        // string str = list[index]; 
        // print(str);
        // list.Remove(str);
        // checkObstacle(Random.Range(0, 3));
    }

    private void checkObstacle(int obstacleType)
    {
        if (obstacleType == 0)
        {
            if (!fireObstacleSet)
            {
                print("red");
                fireObstacleSet = true;
            }
            else
            {
                generateObstacle();
            }
        }

        if (obstacleType == 1)
        {
            if (!waterObstacleSet)
            {
                print("blue");
                waterObstacleSet = true;
            }
            else
            {
                generateObstacle();
            }
        }

        if (obstacleType == 2)
        {
            if (!earthObstacleSet)
            {
                print("green");
                earthObstacleSet = true;
            }
            else
            {
                generateObstacle();
            }
        }

        if (obstacleType == 3)
        {
            if (!airObstacleSet)
            {
                print("white");
                airObstacleSet = true;
            }
            else
            {
                generateObstacle();
            }
        }

        // if (obstacleType == 1)  && waterObstacleSet == false)
        // {
        //     print("blue");
        //     waterObstacleSet = true;
        // }
        // else if (obstacleType == 1 && waterObstacleSet == true)
        // {
        //     generateObstacle();
        // }
        // else if (obstacleType == 2 && earthObstacleSet == false)
        // {
        //     print("green");
        //     earthObstacleSet = true;
        // }
        // else if (obstacleType == 2 && earthObstacleSet == true)
        // {
        //     generateObstacle();
        // }
        // else if (obstacleType == 3 && airObstacleSet == false)
        // {
        //     print("tan");
        //     airObstacleSet = true;
        // }
        // else if (obstacleType == 3 && airObstacleSet == true)
        // {
        //     generateObstacle();
        // }

    }

    public void SpawnObstacle()
    {
        typeOfObstacle = Random.Range(1, 4);
        print("TYPE OF" + typeOfObstacle);
        if (typeOfObstacle == 1)
        {
            fireElem = true;
        }
        else if (typeOfObstacle == 2)
        {
            waterElem = true;
        }
        else if (typeOfObstacle == 3)
        {
            earthElem = true;
        }
        else if (typeOfObstacle == 4)
        {
            airElem = true;
        }
        // List<int> obstacleNumbers = new List<int>();

        fireObstacleSet = false;
        waterObstacleSet = false;
        earthObstacleSet = false;
        airObstacleSet = false;

        var list = new List<int> { 1, 2, 3, 4 };
        print("--------BEGIN------------");
        for (var i = 0; i < 4; i++)
        {
            zSpawn = this.transform.position.z + 100;
            xSpawn = xSpawnA[i];
            // int obstacleType = Random.Range(0, 3);
            // print("Random number is " + obstacleType);
            SphereSpawn = new Vector3(xSpawn, 0f, zSpawn);


            int index = Random.Range(0, list.Count);
            int str = list[index];
            print("------------" + str);
            if (str == 1)
            {
                Instantiate(Sphere1, SphereSpawn, transform.rotation);
                print("location------------" + xSpawn + " " + zSpawn);
            }
            else if (str == 2)
            {
                Instantiate(Sphere2, SphereSpawn, transform.rotation);
                print("location------------" + xSpawn + " " + zSpawn);
            }
            else if (str == 3)
            {
                Instantiate(Sphere3, SphereSpawn, transform.rotation);
                print("location------------" + xSpawn + " " + zSpawn);
            }
            else if (str == 4)
            {
                Instantiate(Sphere4, SphereSpawn, transform.rotation);
                print("location------------" + xSpawn + " " + zSpawn);
            }
            list.Remove(str);

            // generateObstacle();
            int randz = Random.Range(50, 200);


            // checkObstacle();


            // obstacleSpawn = new Vector3(xSpawn, -2f, zSpawn);
            // Instantiate(obstacle, obstacleSpawn, transform.rotation);
        }


    }
    private void onCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere1" && fireElem)
        {
            score += 10;
            print("Score--------" + score);
        }
        else
        {
            playerhealth -= 10;
            print("health--------" + playerhealth);
        }
        if (other.gameObject.tag == "Sphere2" && waterElem)
        {
            score += 10;
            print("Score--------" + score);
        }
        else
        {
            playerhealth -= 10;
            print("health--------" + playerhealth);
        }
        if (other.gameObject.tag == "Sphere3" && earthElem)
        {
            score += 10;
            print("Score--------" + score);
        }
        else
        {
            playerhealth -= 10;
            print("health--------" + playerhealth);
        }
        if (other.gameObject.tag == "Sphere4" && airElem)
        {
            score += 10;
            print("Score--------" + score);
        }
        else
        {
            playerhealth -= 10;
            print("health--------" + playerhealth);
        }
    }

}
