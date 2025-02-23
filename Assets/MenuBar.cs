using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuBar : MonoBehaviour
{
    [SerializeField] Buttons buttons;
    [SerializeField] Button button1;
    [SerializeField] Button button2;
    [SerializeField] GameObject menuBar;
    [SerializeField] Button button0;
    [SerializeField] TMP_Text text;
    public bool ZaWarudo = false;
    int i = 0;

    private void Start()
    {
        if (buttons.polski) text.text = "Aby wyjsc z Menu kliknij Escape Jezeli gra nie wyswietla sie prawidlowo sprobuj zmienic rozdzielczosc w ustawieniach w main menu :)";
        if (buttons.angielski) text.text = "To exit the Escape menu, click Escape If the game is not displaying properly, try changing the resolution in the settings in the main menu :)";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            i++;
        }
        if (i == 1)
        {
            menuBar.SetActive(true);
            button0.gameObject.SetActive(true);
            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            ZaWarudo = true;
        }
        if (i == 2)
        {
            menuBar.SetActive(false);
            button0.gameObject.SetActive(false);
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
            ZaWarudo = false;
            i = 0;
        }
    }

}
