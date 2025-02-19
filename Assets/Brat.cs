using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Brat : MonoBehaviour //Brat prawie skonczony 
{
    [SerializeField] Dialogi dialogi;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    BoxCollider2D box;
    [SerializeField] GameObject materac;
    public bool arriveBrother = false;
    bool gora = true; 
    bool gora_0 = true; 
    bool gora_1 = true; 
    bool lewo = true;
    bool lewo_0 = true;
    bool prawo = true;
    float distanceY = -1.62f;
    float distanceX = -9.33f;
    float speed = 3f;
    int i = 0;
    int j = 0;
    bool komputer = false;

    private void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        Debug.Log("Wybor_1" + buttons.wybor_1);
        if (materac.activeSelf && dialogi.i == 3)
        {
            arriveBrother = true;
        }
        if (arriveBrother)
        {
            if(gora)transform.Translate(speed * Time.deltaTime * Vector2.up);
            if(transform.position.y >= distanceY)
            {
                gora = false;
                if(lewo)transform.Translate(speed * Time.deltaTime * Vector2.left);
                if(transform.position.x <= distanceX)
                {
                    box.isTrigger = false;
                    lewo = false;
                    arriveBrother = false;
                }
            }
        }
        if (!lewo)
        {
            WidziMatetac();
        }
        if (buttons.wybor_1)
        {
            DajeszKompa();
            box.isTrigger = true;
        }
        if (!buttons.wybor_1 && !buttons.wybor_01)
        {
            Grozisz();
            box.isTrigger = true;
        }
        if (buttons.nieOdlanoSie)
        {
            NieOdlanoSie();
        }
    }

    void WidziMatetac()
    {
        if(i <= 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
            }
        }
        if (i == 0) text.text = "Hahaha zaszczales materac";
        if (i == 1) text.text = "Powiem to rodzicom";
        if (i == 2)
        {
            text.text = "Szczerze mowiac jestes w dupie musisz cos zrobic";
            buttons.i = 1;
        }
    }

    void DajeszKompa()
    {
        if (j <= 2) Koniec();
        if (!komputer) //Inaczej droga
        {
            distanceX = -3.42f;
            distanceY = 0.75f;
            if (prawo) transform.Translate(speed * Time.deltaTime * Vector2.right);
            if (transform.position.x >= distanceX)
            {
                prawo = false;
                if (gora_0) transform.Translate(speed * Time.deltaTime * Vector2.up);
            }
            if (transform.position.y >= distanceY)
            {
                gora_0 = false;
            }
        }
    }

    void Grozisz()
    {
        if (j <= 2) Koniec();
        if (prawo)distanceX = -7.27f;
        if(gora_0)distanceY = -5.64f;
        if (prawo) transform.Translate(speed * Time.deltaTime * Vector2.right);
        if (transform.position.x >= distanceX)
        {
            prawo = false;
            if (gora_0) transform.Translate(speed * Time.deltaTime * Vector2.down); //jest ze gora_0 ale idzie w dol
        }
        if (transform.position.y <= distanceY)
        {
            if(!prawo)distanceX = -18.3f;
            if(!gora_0)distanceY = -0.42f;
            gora_0 = false;
            if (lewo_0) transform.Translate(speed * Time.deltaTime * Vector2.left);
            if (transform.position.x <= distanceX)
            {
                lewo_0 = false;
                if (gora_1) transform.Translate(speed * Time.deltaTime * Vector2.up);
                if (transform.position.y >= distanceY)
                {
                    gora_1 = false;
                }
            }
        }
    }

    void NieOdlanoSie()
    {
        transform.position = new Vector2(-18.3f, -0.42f);
    }

    void Koniec()
    {
        if (j <= 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                j++;
            }
        }
        if (j == 0) text.text = "Musze wyprac materac";
        if (j == 1)
        {
            text.text = "";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Komputer"))
        {
            komputer = true;
            transform.position = new Vector2(-3.5f, 2.09f);
        }
    }

}
