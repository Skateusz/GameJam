using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menel : MonoBehaviour
{

    [SerializeField] Wyjscie_2 wyjscie;
    [SerializeField] TMP_Text text;
    [SerializeField] Buttons buttons;
    public bool threeFreeze = false;
    bool one = false;

    private void Update()
    {
        if (wyjscie.kupil && !one)
        {
            one = true;
            threeFreeze = true;
            Rozmowa();
        }
    }

    void Rozmowa()
    {
        if(buttons.i <= 5)
        {
            text.text = "Kierowniku we no poratuj zapracowanego obywatela Rzeczypospolitej";
            buttons.i = 5;
        }
    }

}
