using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Patologia : MonoBehaviour
{
    BoxCollider2D box;
    [SerializeField] Funkcjonariusz policja;
    [SerializeField] Endings ending;
    [SerializeField] Buttons buttons;
    [SerializeField] PulkaSklepowaScript pulka;
    [SerializeField] TMP_Text text;  
    [SerializeField] GameObject EKey;
    [SerializeField] GameObject Patus;
    float speed = 5f;
    float distanceY = 24.27f;
    float distanceY_0 = 40.58f;
    bool inTrigger = false;
    bool canRun = true;
    public bool stop = false;
    bool stopPatus = false;
    bool one = true;
    bool one_0 = true;
    int i = 0;

    private void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E) && one)
        {
            EKey.SetActive(false);
            one = false;
        }
        if (!one && one_0)
        {
            Trawa();
        }
        if (policja.jedenUcieka)
        {
            box.isTrigger = true;
            if (canRun)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.down);
            }
            if (transform.position.y <= distanceY)
            {
                canRun = false;
            }
        }
        if (!Patus.activeSelf)
        {
            if (!canRun && !stopPatus)
            {
                transform.Translate(speed * Time.deltaTime * Vector2.up);
            }
            if (transform.position.y >= distanceY_0)
            {
                stopPatus = true;
                i = 0;
                Rozmowa();
            }
        }
    }

    void Rozmowa()
    {
        if (i <= 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
            }
        }
        if (i == 0)
        {
           if (buttons.polski) text.text = "Ty maly konfidencie zaplacisz za to zyciem!!!";
            if (buttons.angielski) text.text = "You, little confidant, will pay for it with your life!!!";
        }
        if (i == 1)
        {
            if (buttons.wybor_2)
            {
                if (buttons.polski) text.text = "Patus grozi ze cie zabije jednak przypominasz sobie ze masz pistolet";
                if (buttons.angielski) text.text = "Patus threatens to kill you, but you remember that you have a gun";
                buttons.i = 13;
            }
            else
            {
                ending.Ending_10 = true;
            }
        }
        if (buttons.i == 14)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !buttons.wybor_0 && !pulka.wzietoProduct)
        {
            if (buttons.polski) text.text = "Pogadac?";
            if (buttons.angielski) text.text = "Talk?";
            EKey.SetActive(true);
            inTrigger = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            text.text = "";
            EKey.SetActive(false);
            inTrigger = false;
        }
    }

    void Trawa()
    {
        if(i <= 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
            }
        }
        if (i == 0)
        {
            if (buttons.polski) text.text = "Te pizdryk nie chcesz sobie ulzyc troche mamy sporo trawy, skosztujesz?";
             if (buttons.angielski) text.text = "You don't want to relieve yourself a little bit, we have a lot of cock, will you taste it?";
        }
        if (i == 1)
        {
            if (buttons.polski) text.text = "Jakies podejrzane typy do kturych zagadales oferuja ci trawe co robisz?";
             if (buttons.angielski) text.text = "Any suspicious characters you talked to offer you cock what do you do?";
            one_0 = false;
            buttons.i = 11;
        }
    }

}
