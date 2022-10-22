using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int speed;

    private Animator anime;
    private Rigidbody2D body;
    private SpriteRenderer sr;

    private string WALK_ANIMETION = "Walk";

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");  // A D
        movementY = Input.GetAxis("Vertical");    // W S

        Vector2 pos = transform.position;

        pos.x += movementX * speed * Time.deltaTime;
        pos.y += movementY * speed * Time.deltaTime;

        transform.position = pos;
    }

    void AnimatePlayer()
    {
        if(movementX > 0)
        {
            anime.SetBool(WALK_ANIMETION, true);
        }
        if (movementX < 0)
        {
            anime.SetBool(WALK_ANIMETION, true);
        }
        else
        {
            anime.SetBool(WALK_ANIMETION, false);
        }

    }
}
