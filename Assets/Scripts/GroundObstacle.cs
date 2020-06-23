using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundObstacle : MonoBehaviour
{
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
        if (other.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Ground1")
            {
                print("GROUND");
            }
            else
            {
                print("health--------");
            }
            if (this.gameObject.tag == "Ground2")
            {
                print("GROUND");
            }
            else
            {
                print("health--------");
            }
            if (this.gameObject.tag == "Ground3")
            {
                print("GROUND");
            }
            else
            {
                print("health--------");
            }
            if (this.gameObject.tag == "Ground4")
            {
                print("GROUND");
            }
            else
            {
                print("health--------");
            }
        }
    }
}
