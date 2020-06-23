using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
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
            if (this.gameObject.tag == "Sphere1" && GenerateObstacle.fireElem!=true)
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health--------"+GenerateObstacle.playerhealth);
                collision=true;
                
            }
            // else if (this.gameObject.tag == "Sphere1" && GenerateObstacle.fireElem==true)
            // {
            //     GenerateObstacle.playerscore++;
            //     print("score--------"+GenerateObstacle.playerscore);
                
            // }
            else if (this.gameObject.tag == "Sphere2" && GenerateObstacle.waterElem!=true)
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health--------"+GenerateObstacle.playerhealth);
                collision=true;
            }
            // else if (this.gameObject.tag == "Sphere2" && GenerateObstacle.waterElem==true)
            // {
            //     GenerateObstacle.playerscore++;
            //     print("score--------"+GenerateObstacle.playerscore);
                
            // }
            else if (this.gameObject.tag == "Sphere3" && GenerateObstacle.earthElem!=true)
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1;
                print("health--------"+GenerateObstacle.playerhealth);
                collision=true;
                
            }
            // else if (this.gameObject.tag == "Sphere3" && GenerateObstacle.earthElem==true)
            // {
            //     GenerateObstacle.playerscore++;
            //     print("score--------"+GenerateObstacle.playerscore);
                
            // }
            else if (this.gameObject.tag == "Sphere4" && GenerateObstacle.airElem!=true)
            {
                GenerateObstacle.playerhealth=GenerateObstacle.playerhealth-1 ;
                print("health--------"+GenerateObstacle.playerhealth);
                collision=true;
                
            }
            // else if (this.gameObject.tag == "Sphere4" && GenerateObstacle.airElem==true)
            // {
            //     GenerateObstacle.playerscore++;
            //     print("score--------"+GenerateObstacle.playerscore);
                
            // }
        }
    }
    }
    private void OnTriggerExit(Collider other){
        collision = false;
    }
}
