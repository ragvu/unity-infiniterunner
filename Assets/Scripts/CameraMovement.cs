using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static GameObject camera;
    private Vector3 move;
    public GameObject playerLocal;
    private Player playerScript;
    private float cameraX;
    // Start is called before the first frame update
    void Start()
    {
        cameraX = playerLocal.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cameraX, playerLocal.transform.position.y + 35, playerLocal.transform.position.z - 47);
    }
}
