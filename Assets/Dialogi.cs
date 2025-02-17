using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogi : MonoBehaviour
{

    [SerializeField] TMP_Text text;
    public List<string> dialog_0 = new List<string>();
    public bool polski = true;
    public bool angielski = false;

    private void Awake()
    {
        dialog_0.Add("Budzisz sie w srodku nocy i chce ci sie sikac");
        dialog_0.Add("Mozesz isc lub zostac, wtedy unikniesz potwora z korytarza");
    }

}
