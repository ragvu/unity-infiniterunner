using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirObstacle : MonoBehaviour
{
    private bool collision;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(collision==false){
        if (other.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Air1")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
            }
            if (this.gameObject.tag == "Air2")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
            }
            if (this.gameObject.tag == "Air3")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
            }
            if (this.gameObject.tag == "Air4")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
            }
        }
        }
    }
    private void OnTriggerExit(Collider other){
        collision=false;
    }
}
