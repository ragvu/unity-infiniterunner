using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTriggerScript : MonoBehaviour
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
    private void onTriggerEnter(Collider other){
        if(collision==false){
        if(other.gameObject.tag=="Player"){
            GenerateObstacle.playerscore+=25;
            print(GenerateObstacle.playerscore);
            Destroy(other.gameObject);
            collision=true;
        }
        }
    }
    private void onTriggerExit(Collider other){
        collision=false;
    }
}
