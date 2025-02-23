using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogi : MonoBehaviour
{
    [SerializeField] WyboryTekst tekst;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    public List<string> dialog_0 = new List<string>();
    public bool polski = true;
    public bool angielski = false;
    public int i = 0;

    private void Awake() 
    {
        if (buttons.polski) dialog_0.Add("Budzisz sie w srodku nocy i chce ci sie sikac");
        else dialog_0.Add("You wake up in the middle of the night and want to pee");
        if (buttons.polski) dialog_0.Add("Mozesz isc lub zostac, wtedy unikniesz potwora z korytarza");
        if (buttons.angielski) dialog_0.Add("You can go or stay, then you can avoid the corridor monster");
        dialog_0.Add("");
        dialog_0.Add("");
        ///////////////////////////////////////
    }

    private void Update()
    {
        Debug.Log(buttons.wybor_0);
        if (buttons.wybor_0)
        {
            if (buttons.polski) dialog_0[3] = "O nie mam zaszczane lozko, musze cos z tym zrobic";
            if (buttons.angielski) dialog_0[3] = "Oh no my bed is soiled, I have to do something about it";
        }
        //if (!buttons.wybor_0)
        //{
        //    dialog_0[3] = "Mam caly dzien dla siebie co moge porobic";
        //}
    }

}
