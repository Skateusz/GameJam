using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] Menel menel;
    [SerializeField] Endings endings;
    [SerializeField] SzafkaRodzicow szafka;
    [SerializeField] TMP_Text text;
    [SerializeField] Player player;
    [SerializeField] Dialogi dialogi;
    [SerializeField] GameObject[] obiekty;
    public bool wybor_0; 
    public bool wybor_1; 
    public bool wybor_01 = true; //Dla wybor_1
    public bool wybor_2; 
    public bool wybor_03;
    public bool kliknieto = false;
    public bool nieOdlanoSie = false;
    public int i = 0;

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

    public void Lewy()
    {
        if (i == 0) //Wybor 1
        {
            kliknieto = true;
            text.text = "Poszedles sie odlac potwory nie istnieja";
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
            text.text = "Zagroziles bratu ten nic nie powie dopuki nie przyjda rodzice";
            wybor_01 = false;
            wybor_1 = false;
            i++;
        }
        if (i == 3)
        {
            kliknieto = true;
            text.text = "Wzioles bron ze soba";
            obiekty[1].SetActive(false);
            wybor_2 = true;
            szafka.i = 1;
            i++;
        }
        if (i == 5)
        {
            kliknieto = true;
            text.text = "Dales jedzenie bezdomnemu jest mu milo to dobrze czasem zrobic cos dobrego";
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
            text.text = "Powiedziales ze nie musisz wyprac materac ale nie masz jak a nie chcesz miec kary";
            endings.Ending_7 = true;
            i++;
        }
    }

    public void Prawy()
    {
        if (i == 0) //Wybor 1
        {
            kliknieto = true;
            text.text = "Nie poszedles, rano obudziles sie z zaszczanym materacem, potwory nie istnieja debilu";
            obiekty[0].SetActive(true);
            wybor_0 = true;
            dialogi.i++;
        }
        if (i == 1)
        {
            player.gameStart = true;
            kliknieto = true;
            text.text = "Dales bratu kompa, nie wysprzegli sie";
            wybor_1 = true;
            wybor_01 = false;
            i++;
        }
        if (i == 3)
        {
            kliknieto = true;
            text.text = "Zostawiles bron w szafce";
            wybor_2 = false;
            szafka.i = 1;
            i = 7;
        }
        if (i == 5)
        {
            kliknieto = true;
            text.text = "Nie dajesz nic";
            endings.Ending_3 = true;
            i++;
        }
        if (i == 7)
        {
            kliknieto = true;
            text.text = "Nic z tym nie zrobiles";
            i++;
        }
        if (i == 9)
        {
            kliknieto = true;
            text.text = "Powiedziales ze nie musisz wyprac materac ale nie masz jak a nie chcesz miec kary";
            endings.Ending_6 = true;
            i++;
        }
    }

}
