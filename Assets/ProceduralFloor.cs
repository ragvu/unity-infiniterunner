using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralFloor : MonoBehaviour
{
    public Vector3 anchorPoint;
    public Vector3 anchorPoint2;
    private Rigidbody floorInstance;
    public Rigidbody floor;
    public GameObject previousFloor;
    public GameObject[] floorArray;
    public int floorID = 1;
    public GameObject playerLocal;
    public GenerateObstacle generateObstacleScript;
    private int collisionCounter;
    private bool collision;

    // Start is called before the first frame update

    void Start()
    {
        //print("Start method Called " + this.GetHashCode());
        playerLocal = GameObject.Find("Player");
        generateObstacleScript = playerLocal.GetComponent<GenerateObstacle>();

        anchorPoint = new Vector3(floor.transform.position.x, floor.transform.position.y, floor.transform.position.z + 50f);
        anchorPoint2 = new Vector3(floor.transform.position.x, floor.transform.position.y, floor.transform.position.z + 250f);

        collisionCounter = 0;


    }

    // Update is called once per frame
    void Update()
    {
        // floorArray = GameObject.FindGameObjectsWithTag("Floor");
        // for (int i= 0 ; i<floorArray.Length; i++){
        //     floorArray[i].SetActive(i == floorID);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (collision == false)
            {
                print("collided");
                if (collisionCounter == 0)
                {
                    floorInstance = Instantiate(floor, anchorPoint2, floor.transform.rotation);
                    generateObstacleScript.SpawnObstacle();
                    collisionCounter++;
                    collision = true;

                }

                else if (collisionCounter == 1)
                {
                    generateObstacleScript.SpawnObstacle();
                    collision = true;
                }

                else if (collisionCounter == 2)
                {
                    generateObstacleScript.SpawnObstacle();
                    collision = true;
                }
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        collision = false;
    }
}

