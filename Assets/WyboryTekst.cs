using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WyboryTekst : MonoBehaviour
{
    [SerializeField] Dialogi dialogi;
    [SerializeField] TMP_Text text;
    [SerializeField] Button button0;
    [SerializeField] Button button1;
    [SerializeField] TMP_Text button_0;
    [SerializeField] TMP_Text button_1;
    private void Start()
    {
        text.text = dialogi.dialog_0[0];
        button0.gameObject.SetActive(true);
        button_0.text = "Idz sie odlac";
        button1.gameObject.SetActive(true);
        button_1.text = "Nie idz";
    }
}
