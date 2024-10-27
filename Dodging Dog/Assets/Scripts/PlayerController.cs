using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    SpriteRenderer sr;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            //Screen.width returns the whole screen
            //Press the left side of the middle point of the screen
            if (Input.mousePosition.x < Screen.width / 2)
            {
                rb.velocity = Vector2.left * moveSpeed;
                sr.flipX = true;
            }
            else
            {
                rb.velocity = Vector2.right * moveSpeed;
                sr.flipX = false    ;

            }
        }
    }
}
