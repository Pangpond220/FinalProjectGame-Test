using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private Animator anime;
    private Rigidbody2D body;
    private SpriteRenderer sr;

    private string WALK_ANIMETION = "Walk";

    private float movementX;
    private float movementY;

    private bool isGrounded;

    private string GROUND_TAG = "Ground";
    private string SHIPS_TAG9 = "Ships";

    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        PlayerMove();
        AnimatePlayer();
    }

    private void FixedUpdate()
    {
        PlayerJump();
    }

    // Update is called once per frame
    void PlayerMove()
    {
        movementX = Input.GetAxis("Horizontal");  // A D
        movementY = Input.GetAxis("Vertical");    // W S

        Vector2 pos = transform.position;

        pos.x += movementX * speed * Time.deltaTime;
        //pos.y += movementY * speed * Time.deltaTime;

        transform.position = pos;
    }

    void PlayerJump()
    {
        if (movementY > 0 && isGrounded)
        {
            isGrounded = false;
            body.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag(GROUND_TAG)) // Check Player on Ground
        {
            isGrounded = true;
        }
    }

    void AnimatePlayer()
    {
        if(movementX > 0)
        {
            anime.SetBool(WALK_ANIMETION, true);
            sr.flipX = true;
        }
        else if (movementX < 0)
        {
            anime.SetBool(WALK_ANIMETION, true);
            sr.flipX = false;
        }
        else if (movementY < 0 || movementY > 0)
        {
            anime.SetBool(WALK_ANIMETION, true);
        }
        else
        {
            anime.SetBool(WALK_ANIMETION, false);
        }

    }
}
