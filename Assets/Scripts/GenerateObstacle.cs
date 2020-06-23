using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    public static int playerElement; 
    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Sphere3;
    public GameObject Sphere4;
    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public GameObject Ground4;
    public GameObject Air1;
    public GameObject Air2;
    public GameObject Air3;
    public GameObject Air4;
    public GameObject Move1;
    public GameObject Move2;
    public GameObject Move3;
    public GameObject Move4;
    private GameObject playerLocal;
    private Player playerScript;
    public GameObject obstacleLocal;
    public Rigidbody obstacle;
    private DamagePickup obstacleScript;
    public float zSpawn;
    public float airzSpawn;
    public float[] xSpawnA;
    private float xCenter;
    private float xSpawn;
    public static float playerhealth;
    private int obstacleNumber;
    public static float playerscore;
    private int typeOfObstacle;
    // private int obstacleType;
    private Vector3 obstacleSpawn;
    private Vector3 SphereSpawn;
    private Vector3 AirSphereSpawn;
    // Start is called before the first frame update
    public bool fireObstacleSet = false;
    public bool waterObstacleSet = false;
    public bool earthObstacleSet = false;
    private bool airObstacleSet = false;
    public GeneratePowerUps powerUpScript;
    public CoinScript coinScript;
    public static bool fireElem = false;
    public static bool waterElem = false;
    public static bool earthElem = false;
    public static bool airElem = false;
    void Start()
    {
        playerhealth=3f;
        playerLocal = GameObject.Find("Player");
        playerElement = Random.Range(1,4);
        powerUpScript = playerLocal.GetComponent<GeneratePowerUps>();
        coinScript = playerLocal.GetComponent<CoinScript>();
        obstacleLocal = GameObject.Find("Obstacle");
        xCenter = this.transform.transform.position.x + 1.5f;
        xSpawnA = new float[] { xCenter - 4.5f, xCenter - 1.5f, xCenter + 1.5f, xCenter + 4.5f };
        StartCoroutine("DoCheck");
        
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
     IEnumerator DoCheck() {
     for(;;) {
         // execute block of code here
         yield return new WaitForSeconds(5f);
         playerscore+=25;
         print(playerscore);
     }
 }
    public void fourLanes()
    {
        if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }

        var list = new List<int> { 1, 2, 3, 4 };
        for (var i = 0; i < 4; i++)
        {
            zSpawn = this.transform.position.z + 200;
            xSpawn = xSpawnA[i];
            SphereSpawn = new Vector3(xSpawn, 0f, zSpawn);


            int index = Random.Range(0, list.Count);
            int str = list[index];
            
            if (str == 1)
            {
                Instantiate(Sphere1, SphereSpawn, transform.rotation);
            }
            else if (str == 2)
            {
                Instantiate(Sphere2, SphereSpawn, transform.rotation);
            }
            else if (str == 3)
            {
                Instantiate(Sphere3, SphereSpawn, transform.rotation);
            }
            else if (str == 4)
            {
                Instantiate(Sphere4, SphereSpawn, transform.rotation);
            }
            list.Remove(str);

            // generateObstacle();
            int randz = Random.Range(50, 200);


            // checkObstacle();


            // obstacleSpawn = new Vector3(xSpawn, -2f, zSpawn);
            // Instantiate(obstacle, obstacleSpawn, transform.rotation);
        }
    }
    public void groundObstacle()
    {
        if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }

        var list = new List<int> { 1, 2, 3, 4 };
        zSpawn = this.transform.position.z + 200;
        SphereSpawn = new Vector3(xCenter, -2f, zSpawn);


        int index = Random.Range(0, list.Count);
        int str = list[index];
        if(playerElement!=str){
        if (str == 1)
        {
            Instantiate(Ground1, SphereSpawn, transform.rotation);
        }
        else if (str == 2)
        {
            Instantiate(Ground2, SphereSpawn, transform.rotation);
        }
        else if (str == 3)
        {
            Instantiate(Ground3, SphereSpawn, transform.rotation);
        }
        else if (str == 4)
        {
            Instantiate(Ground4, SphereSpawn, transform.rotation);
        }
        list.Remove(str);
        }
        else if(playerElement==str){
            list.Remove(str);
            repeatObstacle();
        }

        // generateObstacle();
        int randz = Random.Range(50, 200);
    }
    public void groundThenAirObstacle(){
    if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }

        var list = new List<int> { 1, 2, 3, 4 };
        zSpawn = this.transform.position.z + 200;
        SphereSpawn = new Vector3(xCenter, -2f, zSpawn);
        airzSpawn = this.transform.position.z + 225;
        AirSphereSpawn = new Vector3(xCenter, 10f, airzSpawn);
        int index = Random.Range(0, list.Count);
        int str=list[index];

        if(playerElement!=str){
        if (str == 1)
        {
            Instantiate(Ground1, SphereSpawn, transform.rotation);
            Instantiate(Air1, AirSphereSpawn, transform.rotation);
        }
        else if (str == 2)
        {
            Instantiate(Ground2, SphereSpawn, transform.rotation);
            Instantiate(Air2, AirSphereSpawn, transform.rotation);
        }
        else if (str == 3)
        {
            Instantiate(Ground3, SphereSpawn, transform.rotation);
            Instantiate(Air3, AirSphereSpawn, transform.rotation);
        }
        else if (str == 4)
        {
            Instantiate(Ground4, SphereSpawn, transform.rotation);
            Instantiate(Air4, AirSphereSpawn, transform.rotation);
        }
        list.Remove(str);
        }
        else if(playerElement==str){
            list.Remove(str);
            repeatObstacle();
        }

        // generateObstacle();

        // generateObstacle();
        int randz = Random.Range(50, 200);

    }
    public void airThenGroundObstacle(){
    if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }

        var list = new List<int> { 1, 2, 3, 4 };
        zSpawn = this.transform.position.z + 225;
        SphereSpawn = new Vector3(xCenter, -2f, zSpawn);
        airzSpawn = this.transform.position.z + 200;
        AirSphereSpawn = new Vector3(xCenter, 10f, airzSpawn);
        int index = Random.Range(0, list.Count);
        int str=list[index];

        if(playerElement!=str){
        if (str == 1)
        {
            Instantiate(Ground1, SphereSpawn, transform.rotation);
            Instantiate(Air1, AirSphereSpawn, transform.rotation);
        }
        else if (str == 2)
        {
            Instantiate(Ground2, SphereSpawn, transform.rotation);
            Instantiate(Air2, AirSphereSpawn, transform.rotation);
        }
        else if (str == 3)
        {
            Instantiate(Ground3, SphereSpawn, transform.rotation);
            Instantiate(Air3, AirSphereSpawn, transform.rotation);
        }
        else if (str == 4)
        {
            Instantiate(Ground4, SphereSpawn, transform.rotation);
            Instantiate(Air4, AirSphereSpawn, transform.rotation);
        }
        list.Remove(str);
        }
        else if(playerElement==str){
            list.Remove(str);
            repeatObstacle();
        }

        // generateObstacle();

        // generateObstacle();
        int randz = Random.Range(50, 200);

    }
    public void airObstacle(){
        
        if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }

        var list = new List<int> { 1, 2, 3, 4 };
        zSpawn = this.transform.position.z + 200;

        SphereSpawn = new Vector3(xCenter+5, 0f, zSpawn);


        int index = Random.Range(0, list.Count);
        int str = list[index];
        if(playerElement!=str){
        if (str == 1)
        {
            Instantiate(Air1, SphereSpawn, transform.rotation);
        }
        else if (str == 2)
        {
            Instantiate(Air2, SphereSpawn, transform.rotation);
        }
        else if (str == 3)
        {
            Instantiate(Air3, SphereSpawn, transform.rotation);
        }
        else if (str == 4)
        {
            Instantiate(Air4, SphereSpawn, transform.rotation);
        }
        list.Remove(str);
        }
        else if (playerElement == str)
            {
                list.Remove(str);
                repeatObstacle();
            }

        // generateObstacle();
        int randz = Random.Range(50, 200);
    }

    public void movingObstacle()
    {
        if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }

        var list = new List<int> { 1, 2, 3, 4 };
        zSpawn = this.transform.position.z + 200;
        int spawnLocation = Random.Range(1,3);
        if (spawnLocation == 1)
        {
            SphereSpawn = new Vector3(xCenter + 5f, 1f, zSpawn);
        }
        else if (spawnLocation == 2)
        {
            SphereSpawn = new Vector3(xCenter - 5f, 1f, zSpawn);
        }

        int index = Random.Range(0, list.Count);
        int str = list[index];
        if(playerElement!=str){
        if (str == 1)
        {
            Instantiate(Move1, SphereSpawn, transform.rotation);
        }
        else if (str == 2)
        {
            Instantiate(Move2, SphereSpawn, transform.rotation);
        }
        else if (str == 3)
        {
            Instantiate(Move3, SphereSpawn, transform.rotation);
        }
        else if (str == 4)
        {
            Instantiate(Move4, SphereSpawn, transform.rotation);
        }
        list.Remove(str);
        }
        else if (playerElement == str)
            {
                list.Remove(str);
                repeatObstacle();
            }
        

        // generateObstacle();
        int randz = Random.Range(50, 200);
    }

    public void threelane()
    {
        if (playerElement == 1)
        {
            fireElem = true;
        }
        else if (playerElement == 2)
        {
            waterElem = true;
        }
        else if (playerElement == 3)
        {
            earthElem = true;
        }
        else if (playerElement == 4)
        {
            airElem = true;
        }
 
        var list = new List<int> { 1, 2, 3, 4 };
        for (var i = 0; i < 4; i++)
        {
            zSpawn = this.transform.position.z + 200;
            xSpawn = xSpawnA[i];
            SphereSpawn = new Vector3(xSpawn, 0f, zSpawn);


            int index = Random.Range(0, list.Count);
            int str = list[index];
            if (playerElement != str)
            {
                if (str == 1)
                {
                    Instantiate(Sphere1, SphereSpawn, transform.rotation);
                }
                else if (str == 2)
                {
                    Instantiate(Sphere2, SphereSpawn, transform.rotation);
                }
                else if (str == 3)
                {
                    Instantiate(Sphere3, SphereSpawn, transform.rotation);
                }
                else if (str == 4)
                {
                    Instantiate(Sphere4, SphereSpawn, transform.rotation);
                }
                list.Remove(str);

                // generateObstacle();
                int randz = Random.Range(50, 200);
            }

            else if (playerElement == str)
            {
                list.Remove(str);
            }
        }
    }
    public void SpawnObstacle()
    {
        coinScript.CreateCoins();
        obstacleNumber = Random.Range(0, 45);
        
        if (obstacleNumber >=1 && obstacleNumber <= 10)
        {
            fourLanes();
        }
        else if (obstacleNumber >=11&&obstacleNumber<=14)
        {
            groundObstacle();
        }
        else if (obstacleNumber >=15 && obstacleNumber<=18)
        {
            airObstacle();
            
        }
        else if (obstacleNumber >=19&&obstacleNumber<=25)
        {
            movingObstacle();
        }
        else if (obstacleNumber >= 26&&obstacleNumber<=29)
        {
            airThenGroundObstacle();
        }
        if(obstacleNumber>=30&&obstacleNumber<=35){
            threelane();
        }
        else if(obstacleNumber>=36&&obstacleNumber<=40){
            groundThenAirObstacle();
        }
        else if(obstacleNumber>=41&&obstacleNumber<=45){
            powerUpScript.CreatePowerups();
        }
    }
    public void repeatObstacle(){
        obstacleNumber = Random.Range(0, 45);
        if (obstacleNumber >=1 && obstacleNumber <= 10)
        {
            fourLanes();
        }
        else if (obstacleNumber >=11&&obstacleNumber<=14)
        {
            groundObstacle();
        }
        else if (obstacleNumber >=15 && obstacleNumber<=18)
        {
            airObstacle();
            
        }
        else if (obstacleNumber >=19&&obstacleNumber<=25)
        {
            movingObstacle();
        }
        else if (obstacleNumber >= 26&&obstacleNumber<=29)
        {
            airThenGroundObstacle();
        }
        if(obstacleNumber>=30&&obstacleNumber<=35){
            threelane();
        }
        else if(obstacleNumber>=36&&obstacleNumber<=40){
            groundThenAirObstacle();
        }
        else if(obstacleNumber>=41&&obstacleNumber<=45){
            powerUpScript.CreatePowerups();
        }
    }
}


