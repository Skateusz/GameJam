using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] Kosmici kosmici;
    [SerializeField] Menel menel;
    [SerializeField] Endings endings;
    [SerializeField] SzafkaRodzicow szafka;
    [SerializeField] TMP_Text text;
    [SerializeField] TMP_Text mainText;
    [SerializeField] TMP_Text specialText;
    [SerializeField] Player player;
    [SerializeField] Dialogi dialogi;
    [SerializeField] GameObject[] obiekty;
    [SerializeField] Button[] button;
    public bool wybor_0; 
    public bool wybor_1; 
    public bool wybor_01 = true; //Dla wybor_1
    public bool wybor_2; 
    public bool wybor_02; 
    public bool wybor_03;
    public bool wybor_04;
    public bool wybor_05;
    public bool wybor_06;
    public bool wybor_07;
    public bool kliknieto = false;
    public bool nieOdlanoSie = false;
    public int i = 0;
    public bool polski = false;
    public bool angielski = true;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        Debug.Log(i);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Settings()
    {
        button[0].gameObject.SetActive(false);
        button[1].gameObject.SetActive(false);
        button[2].gameObject.SetActive(false);
        button[3].gameObject.SetActive(false);
        mainText.text = "Ustawienia";
        button[4].gameObject.SetActive(true);
        button[5].gameObject.SetActive(true);
        button[6].gameObject.SetActive(true);
    }

    public void Back()
    {
        button[0].gameObject.SetActive(true);
        button[1].gameObject.SetActive(true);
        button[2].gameObject.SetActive(true);
        button[3].gameObject.SetActive(true);
        mainText.text = "A Regular day";
        button[4].gameObject.SetActive(false);
        button[5].gameObject.SetActive(false);
        button[6].gameObject.SetActive(false);
    }

    public void Endings()
    {
        if (polski) specialText.text = "Gra ma 16 zakonczen czy bedziesz potrafil znalezc wszystkie?";
        if (angielski) specialText.text = "The game had 16 endings can you fing them all?";
    }

    public void Polski()
    {
        polski = true;
        angielski = false;
    }

    public void English()
    {
        polski = false;
        angielski = true;
    }

    public void R1()
    {
        Screen.SetResolution(1366, 768, true);
    }

    public void R2()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Lewy()
    {
        if (i == 0) //Wybor 1
        {
            kliknieto = true;
            if (polski) text.text = "Poszedles sie odlac potwory nie istnieja";
            if (angielski) text.text = "You went to pour the monsters don't exist";
            obiekty[1].SetActive(true);
            player.gameStart = true;
            nieOdlanoSie = true;    
            wybor_0 = false;
            dialogi.i++;
        }
        if(i == 1)
        {
            player.gameStart = true;
            kliknieto = true;
            if (polski) text.text = "Zagroziles bratu ten nic nie powie dopuki nie przyjda rodzice";
            if (angielski) text.text = "You threatened your brother, he won't say anything until his parents come";
            wybor_01 = false;
            wybor_1 = false;
            i++;
        }
        if (i == 3)
        {
            kliknieto = true;
            if (polski) text.text = "Wzioles bron ze soba";
            if (angielski) text.text = "You took a gun with you";
            //obiekty[1].SetActive(false);
            wybor_2 = true;
            szafka.i = 1;
            i++;
        }
        if (i == 5)
        {
            kliknieto = true;
            if (polski) text.text = "Dales jedzenie bezdomnemu jest mu milo to dobrze czasem zrobic cos dobrego";
            if (angielski) text.text = "You gave food to a homeless person, it's nice for him, it's good to do something good sometimes";
            menel.threeFreeze = false;
            wybor_03 = true;
            i++;
        }
        if (i == 7)
        {
            kliknieto = true;
            endings.Ending_5 = true;
            i++;
        }
        if (i == 9)
        {
            kliknieto = true;
            if (polski) text.text = "Powiedziales ze musisz wyprac materac ale nie masz jak a nie chcesz miec kary";
            if (angielski) text.text = "You said you have to wash the mattress but you don't have a way and you don't want to be punished";
            if (!wybor_1)endings.Ending_7 = true;
            if (wybor_1)endings.Ending_16 = true;
            i++;
        }
        if (i == 11)
        {
            kliknieto = true;
            if (polski) text.text = "Wziales trawe";
            if (angielski) text.text = "You took cock";
            wybor_04 = true;
            obiekty[2].SetActive(true);
            i++;
        }
        if (i == 13)
        {
            kliknieto = true;
            if (polski) text.text = "Strzeliles, patus nie zyje";
            if (angielski) text.text = "You shot a gun, pathus is dead";
            wybor_05 = true;
            i++;
        }
        if (i == 15)
        {
            kliknieto = true;
            endings.Ending_11 = true;
            i++;
        }
        if (i == 17)
        {
            kliknieto = true;
            wybor_06 = true;
            i++;
            if (polski) text.text = "Zgodziles sie pojsc za nieznajomymi";
            if (angielski) text.text = "You agreed to follow strangers";
        }
        if (i == 19)
        {
            kliknieto = true;
            endings.Ending_13 = true;
            i++;
        }
    }

    public void Prawy()
    {
        if (i == 0) //Wybor 1
        {
            kliknieto = true;
            if (polski) text.text = "Nie poszedles, rano obudziles sie z zaszczanym materacem, potwory nie istnieja debilu";
            if (angielski) text.text = "You didn't go, you woke up in the morning with a pissed mattress, monsters don't exist, moron";
            obiekty[0].SetActive(true);
            wybor_0 = true;
            dialogi.i++;
        }
        if (i == 1)
        {
            player.gameStart = true;
            kliknieto = true;
            if (polski) text.text = "Dales bratu kompa, nie wysprzegli sie";
            if (angielski) text.text = "You gave your brother a computer, they didn't decouple";
            wybor_1 = true;
            wybor_01 = false;
            i++;
        }
        if (i == 3)
        {
            kliknieto = true;
            if (polski) text.text = "Zostawiles bron w szafce";
            if (angielski) text.text = "You left gun in the locker";
            wybor_2 = false;
            wybor_02 = true;
            szafka.i = 1;
            i++;
            //i = 7;
        }
        if (i == 5)
        {
            kliknieto = true;
            if (polski) text.text = "Nie dajesz nic";
            if (angielski) text.text = "You don't give anything";
            endings.Ending_3 = true;
            i++;
        }
        if (i == 7)
        {
            kliknieto = true;
            if (polski) text.text = "Nic z tym nie zrobiles";
            if (angielski) text.text = "You do nothing with this";
            i++;
        }
        if (i == 9)
        {
            kliknieto = true;
            //if (polski) text.text = "Powiedziales ze nie musisz wyprac materac ale nie masz jak a nie chcesz miec kary";
            endings.Ending_6 = true;
            i++;
        }
        if (i == 11)
        {
            kliknieto = true;
            if (polski) text.text = "Wezwales policje";
            if (angielski) text.text = "You called the police";
            wybor_05 = true;
            obiekty[2].SetActive(true);
            i++;
        }
        if (i == 13)
        {
            kliknieto = true;
            wybor_05 = false;
            i++;
            endings.Ending_10 = true;
        }
        if (i == 15)
        {
            kliknieto = true;
            i++;
            endings.Ending_12 = true;
        }
        if (i == 17)
        {
            kliknieto = true;
            i++;
            if (polski) text.text = "Uznales ze sa dziwni i ich olales";
            if (angielski) text.text = "You decided that they are weird and you have ignored them";
            kosmici.echoesAct3ThreeFreeze = false;
        }
        if (i == 19)
        {
            kliknieto = true;
            kosmici.echoesAct3ThreeFreeze = false;
            i++;
            if (polski) text.text = "Run!!!";
            wybor_07 = true;
            kosmici.collidery[1].SetActive(false);
        }
    }


}
