using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
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
            if (other.gameObject.tag == "Sphere1")
            {
                print("Score--------");
            }
            else
            {
                print("health--------");
            }
            if (other.gameObject.tag == "Sphere2")
            {
                print("Score--------");
            }
            else
            {
                print("health--------");
            }
            if (other.gameObject.tag == "Sphere3")
            {
                print("Score--------");
            }
            else
            {
                print("health--------");
            }
            if (other.gameObject.tag == "Sphere4")
            {
                print("Score--------");
            }
            else
            {
                print("health--------");
            }
        }
    }
}
