using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Menel menel;
    BoxCollider2D box;
    public bool gameStart = false;
    Rigidbody2D rb;
    float speed = 5f;
    float dirX;
    float dirY;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        if (gameStart && !menel.threeFreeze)
        {
            Walk();
            box.isTrigger = false;
        }
    }

    void Walk()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(speed * dirX, speed * dirY);
    }

}
