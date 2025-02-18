using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogi : MonoBehaviour
{

    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    public List<string> dialog_0 = new List<string>();
    public bool polski = true;
    public bool angielski = false;
    public int i = 0;

    private void Awake() 
    {
        dialog_0.Add("Budzisz sie w srodku nocy i chce ci sie sikac");
        dialog_0.Add("Mozesz isc lub zostac, wtedy unikniesz potwora z korytarza");
        dialog_0.Add("");
        if (buttons.wybor_0) dialog_0.Add("O nie mam zaszczane lozko, musze cos z tym zrobic");
        else dialog_0.Add("Mam caly dzien dla siebie co moge porobic");
        dialog_0.Add("");
        ///////////////////////////////////////
    }

}
