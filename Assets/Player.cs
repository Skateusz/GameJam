using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Kosmici kosmici;
    [SerializeField] TMP_Text text;
    [SerializeField] Funkcjonariusz policja;
    [SerializeField] Patologia patus;
    [SerializeField] GameObject patusGO;
    [SerializeField] Buttons buttons;
    [SerializeField] Menel menel;
    [SerializeField] Sprite[] sprites;
    BoxCollider2D box;
    public bool gameStart = false;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    float speed = 5f;
    float dirX;
    float dirY;
    int lastDirX = 0;
    Vector2 dir;
    int i = 0;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        if (buttons.wybor_02 && i <= 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
            }
            if(i == 0)
            {
                if (buttons.polski) text.text = "Niepokoi cie to ze twoj tata ma bron w domu (kliknik LPM pare razy)";
                if (buttons.angielski) text.text = "You are afraid that your father has gun in home (click LMP some times)";
            }
            if (i == 1)
            {
                buttons.i = 7;
                i++;
            }
        }
        dir.x = Input.GetAxisRaw("Horizontal");
        if (gameStart && !menel.threeFreeze && !policja.youCantWalk && !patus.stop && !kosmici.echoesAct3ThreeFreeze)
        {
            Walk();
            Obrot();
            box.isTrigger = false;
        }
        if (!patusGO.activeSelf && buttons.wybor_05 && buttons.i < 15)
        {
            text.text = "O nie zabilem czlowieka, co robic?";
            buttons.i = 15;
        }
    }

    void Obrot()
    {
        if (lastDirX != (int)dir.x)
        {
            if (dir.x == 0) return;
            int rotY = dir.x > 0 ? 0 : 180;
            transform.localRotation = Quaternion.Euler(0f, rotY, 0f);
            lastDirX = (int)dir.x;
        }
    }
    void Walk()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(speed * dirX, speed * dirY);
    }

}
