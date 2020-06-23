using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundObstacle : MonoBehaviour
{
    private bool collision;
    // Start is called before the first frame update
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
            if (this.gameObject.tag == "Ground1")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
                collision=true;
            }
            if (this.gameObject.tag == "Ground2")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
                collision=true;
            }
            if (this.gameObject.tag == "Ground3")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
                collision=true;
            }
            if (this.gameObject.tag == "Ground4")
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health " + GenerateObstacle.playerhealth);
                collision=true;
            }
        }
        }
        
    }
    private void OnTriggerExit(Collider other){
        collision=false;
    }
}
