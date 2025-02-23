using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kosmici : MonoBehaviour
{

    public GameObject[] collidery;
    [SerializeField] Buttons buttons;
    [SerializeField] PulkaSklepowaScript pulka;
    [SerializeField] Endings endings;
    [SerializeField] GameObject EKey;
    [SerializeField] GameObject player;
    [SerializeField] TMP_Text text;
    float distanceY = 81.97f;
    float distanceY_0 = 80f;
    float speed = 4f;
    bool inTrigger = false;
    bool rozmawiaj = false;
    bool droga = true;
    bool droga_0 = true;
    public bool echoesAct3ThreeFreeze = false;
    public bool gonGo = true;
    bool one = true;
    int i = 0;

    void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            echoesAct3ThreeFreeze = true;
            rozmawiaj = true;
        }
        if (rozmawiaj)
        {
            Rozmowa();
        }
        if (buttons.wybor_06)
        {
            collidery[0].SetActive(true);
            if (one) collidery[1].SetActive(true);
            if (droga)
            {
                one = false;
                transform.Translate(speed * Time.deltaTime * Vector2.up);
            }
            if (droga_0) player.transform.Translate(speed * Time.deltaTime * Vector2.up);
            if (player.transform.position.y >= distanceY_0)
            {
                droga_0 = false;
            }
            if (transform.position.y >= distanceY)
            {
                droga = false;
                Rozmowa_0();
            }
        }
        if (buttons.wybor_07 && gonGo)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.down);
        }
        if (player.transform.position.y <= 56 && buttons.wybor_07)
        {
            gonGo = false;
            collidery[1].SetActive(true);
        }
    }

    void Rozmowa()
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
            if (buttons.polski) text.text = "Witaj kolego czy zechcialbys zobaczyc cos niesamowitego?";
            if (buttons.angielski) text.text = "Hello buddy, would you like to see something amazing?";
        }
        if (i == 1)
        {
            if (buttons.polski) text.text = "Pokazemy ci miejsca o ktorych ci sie nawet nie snilo";
            if (buttons.angielski) text.text = "We'll show you places you haven't even dreamed of";
        }
        if (i == 2)
        {
            buttons.i = 17;
            rozmawiaj = false;
        }
    }

    void Rozmowa_0()
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
            if (buttons.polski) text.text = "Oto jestesmy";
            if (buttons.angielski) text.text = "There we are";
        }
        if (i == 1)
        {
            if (buttons.polski) text.text = "To urzadzenie zabierze nas w miejsce o ktorych nawet nam sie nie snilo";
            if (buttons.angielski) text.text = "This device will take us to a place we have not even dreamed of";
        }
        if (i == 2)
        {
            if (buttons.polski) text.text = "Wsiadaj";
            if (buttons.angielski) text.text = "Get in";
        }
        if (i == 3)
        {
            buttons.i = 19;
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
        if (collision.collider.CompareTag("Player") && buttons.wybor_07)
        {
            endings.Ending_14 = true;
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

}
