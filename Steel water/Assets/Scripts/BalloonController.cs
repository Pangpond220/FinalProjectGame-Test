using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    private float UpSpeed = 5f;
    private float FlySped = 5f;

    private float MoveMentX;
    private float MoveMentY = 5f;

    private Transform Ship;
    private Vector3 ShipPos;
    private string TAG_SHIP = "Ship";

    // Start is called before the first frame update
    void Start()
    {
        Ship = GameObject.FindWithTag(TAG_SHIP).transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ShipPos = transform.position;
            ShipPos.y += MoveMentY * UpSpeed * Time.deltaTime;

            transform.position = ShipPos;
        }
    }
}
