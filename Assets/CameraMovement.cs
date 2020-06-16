using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject camera;
    private Vector3 move;
    private GameObject playerLocal;
    private Player playerScript;
    // Start is called before the first frame update
    void Start()
    {

        playerLocal = GameObject.Find("Player");
        playerScript = playerLocal.GetComponent<Player>();

         move = new Vector3(0f, .4f, playerScript.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * Time.deltaTime * 10);
    }
}
