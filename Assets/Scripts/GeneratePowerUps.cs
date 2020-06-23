using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePowerUps : MonoBehaviour
{
    // Start is called before the first frame update
    public float[] xSpawnA;
    private float xCenter;
    private float xSpawn;
    private float zSpawn;
    private Vector3 powerUpSpawn;
    

    public GameObject ElementSwitcher;
    void Start()
    {
        xCenter = this.transform.transform.position.x + 1.5f;
        xSpawnA = new float[] { xCenter - 4.5f, xCenter - 1.5f, xCenter + 1.5f, xCenter + 4.5f };
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CreatePowerups()
    {
        zSpawn = this.transform.position.z + 200;
        xSpawn = xSpawnA[Random.Range(1,4)];
        powerUpSpawn = new Vector3(xSpawn, 0f, zSpawn);
        Instantiate(ElementSwitcher, powerUpSpawn, transform.rotation);
    }
}
