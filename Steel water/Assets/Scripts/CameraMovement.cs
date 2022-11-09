using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform player;

    [SerializeField]
    private float cameraUP;

    private Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;
        tempPos.x = player.position.x;
        tempPos.y = player.position.y + cameraUP;

        transform.position = tempPos;
    }
}
