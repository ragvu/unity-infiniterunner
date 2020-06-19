using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    private GameObject playerLocal;
    private Player playerScript;
    private GameObject obstacleLocal;
    public Rigidbody obstacle;
    private DamagePickup obstacleScript;
    public float zSpawn;
    public int[] xSpawnA;
    private float playerX;
    private int playerXi;
    private int xSpawn;
    private Vector3 obstacleSpawn;
    // Start is called before the first frame update
    void Start()
    {
        obstacleLocal = GameObject.Find("Obstacle");
        playerX = this.transform.transform.position.x;
        playerXi = Mathf.RoundToInt(playerX);
        //print(playerXi);
        xSpawnA = new int[] { playerXi - 3, playerXi, playerXi + 3 };
        //print(xSpawnA[0]);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnObstacle()
    {
        int i = 0;
        for (i = 0; i < 8; i++)
        {
            int randx = Random.Range(0, 3);
            int randz = Random.Range(50, 200);

            zSpawn = this.transform.position.z + randz;
            xSpawn = xSpawnA[randx];
            obstacleSpawn = new Vector3(xSpawn, -2f, zSpawn);
            Instantiate(obstacle, obstacleSpawn, transform.rotation);
        }


    }

}
