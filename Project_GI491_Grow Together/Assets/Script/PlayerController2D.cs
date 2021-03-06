using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerController2D : MonoBehaviour
{
    float speed = 5.0f;
    Rigidbody2D rb;
    Animator anim;
    Vector2 direction;
    SpriteRenderer spritePlayer;
    float dirFireX;
    float dirFireY;
    float mass;
    float acceleration = 300;

    public static bool InShop = false;

    // Start is called before the first frame update
    void Start()
    {
        mass = GetComponent<Rigidbody2D>().mass;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spritePlayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (InShop == false)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");
            anim.SetFloat("Horizontal", direction.x);
            anim.SetFloat("Vertical", direction.y);
            anim.SetFloat("speed", direction.sqrMagnitude);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dirFireX = mass * -1 * acceleration;
                dirFireY = 0f;
                spritePlayer.flipX = true;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                spritePlayer.flipX = false;
                dirFireX = mass * acceleration;
                dirFireY = 0f;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                dirFireX = 0f;
                dirFireY = mass * acceleration;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                dirFireX = 0f;
                dirFireY = mass * -1 * acceleration;
            }
            spritePlayer.sortingOrder = 2;
        }
        else
        {
            spritePlayer.sortingOrder = -1;
        }

        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
    }
}
