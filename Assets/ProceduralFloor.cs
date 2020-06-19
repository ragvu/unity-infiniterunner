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
    private int collisionCounter = 0;

    // Start is called before the first frame update

    void Start()
    {
        //print("Start method Called " + this.GetHashCode());
        playerLocal = GameObject.Find("Player");
        generateObstacleScript = playerLocal.GetComponent<GenerateObstacle>();

        anchorPoint = new Vector3(floor.transform.position.x, floor.transform.position.y, floor.transform.position.z + 50f);
        anchorPoint2 = new Vector3(floor.transform.position.x, floor.transform.position.y, floor.transform.position.z + 250f);


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
            if (collisionCounter == 0)
            {
                floorInstance = Instantiate(floor, anchorPoint2, floor.transform.rotation);
                generateObstacleScript.SpawnObstacle();
                collisionCounter++;
            }
            
            else if (collisionCounter == 1){
                // floorInstance = Instantiate(floor, anchorPoint2, floor.transform.rotation);
                // generateObstacleScript.SpawnObstacle();
            }
            
            
            
            
            
            // floorID++;
            // floorInstance.gameObject.name = floorID.ToString();
            // if (floorID != 1)
            // {
            //     int previousTag = floorID - 1;
            //     previousFloor = GameObject.Find(previousTag.ToString());
            //     Destroy(previousFloor.gameObject);
            // }
        }
    }
}

