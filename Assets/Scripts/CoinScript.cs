using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float[] xSpawnA;
    private float xCenter;
    private float xSpawn1;
    private float zSpawn1;
    private Vector3 coinSpawn1;

    private float xSpawn;
    private float zSpawn;
    private Vector3 coinSpawn;
    private float xSpawn2;
    private float zSpawn2;
    private Vector3 coinSpawn2;

    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    public GameObject Coin4;
    public GameObject CoinType;
    void Start()
    {
        xCenter = this.transform.transform.position.x + 1.5f;
        xSpawnA = new float[] { xCenter - 4.5f, xCenter - 1.5f, xCenter + 1.5f, xCenter + 4.5f };
    }
    public void CreateCoins()
    {
        for (var i = 0; i < 4; i++)
        {
            if (GenerateObstacle.playerElement == 1)
            {
                CoinType = Coin1;
            }
            else if (GenerateObstacle.playerElement == 2)
            {
                CoinType = Coin2;
            }
            else if (GenerateObstacle.playerElement == 3)
            {
                CoinType = Coin3;
            }
            else if (GenerateObstacle.playerElement == 4)
            {
                CoinType = Coin4;
            }
            zSpawn = this.transform.position.z + Random.Range(140,180);
            xSpawn = xSpawnA[Random.Range(1, 4)];
            coinSpawn = new Vector3(xSpawn, 0f, zSpawn);

            int p = Random.Range(0, 2);
            if (p == 1)
            {
                Instantiate(CoinType, coinSpawn, transform.rotation);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
