﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void onTriggerEnter(Collider other){
        print("OBSTACLE HIT");
        if(other.gameObject.tag=="Player"){
            if(this.gameObject.tag == "Sphere1"){
                print("Score--------");
                print("TRUEEEE");
            }
            else{

                print("health--------");
            }
            if(this.gameObject.tag=="Sphere2"){
                print("Score--------");
                print("TRUEEEE");
            }
            else{
                print("health--------");
            }
            if(this.gameObject.tag=="Sphere3" ){
                print("Score--------");
                print("TRUEEEE");
            }
            else{
                
                print("health--------");
            }
            if(this.gameObject.tag=="Sphere4"){
                print("Score--------");
                print("TRUEEEE");
            }
            else{
                print("health--------");
            }
        }
    }
}
