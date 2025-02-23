using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Funkcjonariusz : MonoBehaviour
{

    [SerializeField] GameObject patus;
    [SerializeField] Buttons buttons;
    [SerializeField] Endings endings;
    [SerializeField] TMP_Text text;
    float distanceX = -46.81f;
    float distanceX_0 = -27.9f;
    float speed = 5f;
    bool canWalk = true;
    public bool youCantWalk = false;
    public bool jedenUcieka = false;
    bool one = true;
    int i = 0;

    private void Update()
    {
        if (buttons.wybor_04)
        {
            if (canWalk)
            {
                youCantWalk = true;
                transform.Translate(speed * Time.deltaTime * Vector2.left);
            }
            if (transform.position.x <= distanceX)
            {
                canWalk = false;
                Rozmowa();
            }
        }
        if (buttons.wybor_05 && one)
        {
            if (canWalk)
            {
                youCantWalk = true;
                transform.Translate(speed * Time.deltaTime * Vector2.left);
            }
            if (transform.position.x <= distanceX)
            {
                canWalk = false;
                jedenUcieka = true;
                Rozmowa_0();
            }
        }
        if (!one)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
            patus.transform.Translate(speed * Time.deltaTime * Vector2.right);
            if (transform.position.x >= distanceX_0)
            {
                patus.SetActive(false);
                gameObject.SetActive(false);
                youCantWalk = false;
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
            if (buttons.polski) text.text = "UUU a co panowie wyprawiaja";
            if (buttons.angielski) text.text = "UUU, what are you doing";
        }
        if (i == 1)
        {
            text.text = "Bierzecie narkotyki!?";
        }
        if (i == 2)
        {
            if (buttons.polski) text.text = "Kij z tym ze nie jestescie w wieku karalnym wszyscy trafiacie za kraty!!!";
            if (buttons.angielski) text.text = "The problem is that you are not of criminal age, you all end up behind bars!!";
        }
        if (i == 3) endings.Ending_9 = true;
    }

    void Rozmowa_0()
    {
        if (i <= 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
            }
        }
        if (i == 0)
        {
            if (buttons.polski) text.text = "UUU a co panowie wyprawiaja";
            if (buttons.angielski) text.text = "UUU, what are you doing";
        }
        if (i == 1)
        {
            if (buttons.polski) text.text = "Bierzecie narkotyki!?";
            if (buttons.angielski) text.text = "Do you take drugs!?";
        }
        if (i == 2)
        {
            if (buttons.polski) text.text = "Dobra robota mlody zabieram go ze soba";
            if (buttons.angielski) text.text = "Well done young I take it with me";
            one = false;
        }
    }

}
