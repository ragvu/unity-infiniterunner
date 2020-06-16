using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePickup : MonoBehaviour
{
    public GameObject playerLocal;
    public Player playerScript;
    // Start is called before the first frame update
    void Start()
    {
       playerLocal = GameObject.Find("Player");
       playerScript = playerLocal.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        playerScript.health--;
        print(playerScript.health);
    }
}
