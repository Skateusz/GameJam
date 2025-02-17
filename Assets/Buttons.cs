using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public bool kliknieto = false;
    int i = 0;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Lewy()
    {
        if (i == 0)
        {
            kliknieto = true;
            text.text = "Poszedles sie odlac potwory nie istnieja";
            i++;
        }
    }

    public void Prawy()
    {
        if (i == 0)
        {
            kliknieto = true;
            text.text = "Nie poszedles, rano obudziles sie z zaszczanym materacem, potwory nie istnieja debilu";
            i++;
        }
    }

}
