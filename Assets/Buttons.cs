using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] Player player;
    [SerializeField] Dialogi dialogi;
    [SerializeField] GameObject[] obiekty;
    public bool wybor_0 = false; 
    public bool wybor_1 = false; 
    public bool wybor_2 = false; 
    public bool kliknieto = false;
    int i = 0;

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
            player.gameStart = true;
            kliknieto = true;
            text.text = "Poszedles sie odlac potwory nie istnieja";
            wybor_0 = false;
            dialogi.i++;
            i++;
        }
    }

    public void Prawy()
    {
        if (i == 0) //Wybor 1
        {
            player.gameStart = true;
            kliknieto = true;
            text.text = "Nie poszedles, rano obudziles sie z zaszczanym materacem, potwory nie istnieja debilu";
            obiekty[0].SetActive(true);
            wybor_0 = true;
            dialogi.i++;
            i++;
        }
    }

}
