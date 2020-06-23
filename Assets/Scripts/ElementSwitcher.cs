using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSwitcher : MonoBehaviour
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
        GenerateObstacle.playerElement = Random.Range(1, 5);
        print(GenerateObstacle.playerElement);
    }
}
