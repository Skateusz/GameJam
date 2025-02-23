using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Endings : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Buttons buttons;
    [SerializeField] GameObject background;
    [SerializeField] TMP_Text glownyText;
    [SerializeField] Camera cam;
    [SerializeField] TMP_Text text;
    [SerializeField] Button restart;
    public bool Ending_0 = false;
    public bool Ending_1 = false;
    public bool Ending_2 = false;
    public bool Ending_3 = false;
    public bool Ending_4 = false;
    public bool Ending_5 = false;
    public bool Ending_6 = false;
    public bool Ending_7 = false;
    public bool Ending_8 = false;
    public bool Ending_9 = false;
    public bool Ending_10 = false;
    public bool Ending_11 = false;
    public bool Ending_12 = false;
    public bool Ending_13 = false;
    public bool Ending_14 = false;
    public bool Ending_15 = false;
    public bool Ending_16 = false;

    private void Update()
    {
        if (Ending_0) 
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski)text.text = "Grales caly dzien rodzice zostawili ci liste rzeczy do zrobienia o ktorej nie wiedziales mimo to rodzice sa zli masz KARE";
            if (buttons.angielski) text.text = "You played all day, your parents left you a to-do list you didn't know about, yet your parents are angry -- you have a PUNISHMENT";
            glownyText.text = "";
            background.SetActive(false);
        }
        if (Ending_1) 
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Jestes debilem pierzesz materac w pralce przez co sie niszczy masz KARE";
            if (buttons.angielski) text.text = "You're a moron to wash your mattress in the washing machine so it gets ruined --- you have a PUNISHMENT";
            glownyText.text = "";
            background.SetActive(false);
        }
        if (Ending_2)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Nakryto cie na kradziezy jednak jestes za mlody by zostac ukaranym twoi rodzice ida do wiezienia!!!";
            if (buttons.angielski) text.text = "You were caught stealing, however you are too young to be punished, your parents are going to jail!!!!";
            glownyText.text = "";
            background.SetActive(false);
        }
        if (Ending_3)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Nie dales bezdomnemu jedzenia, dlatego ten by je zdobyc zabija cie i je bierze NIE ZYJESZ!!!";
            if (buttons.angielski) text.text = "You didn't give the homeless man food, so in order to get it he kills you and takes it --- YOU DIE!!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_4)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Wruciles do domu, rodzice sa zli bo nic nie robiles caly dzien jednak nagle przychodzi bezdomny i dziekuje ci przy rodzicach ktorzy sa z ciebie dumni NIE MASZ KARY";
            if (buttons.angielski) text.text = "You come home, your parents are angry because you haven't done anything all day, but suddenly a homeless person comes in and thanks you in front of your parents who are proud of you --- YOU HAVE NO PUNISHMENT";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_5)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Twoj ojciec nie ma pozwolenia na bron zgarnela go policja mama daje ci KARE (+ masz makowiec)";
            if (buttons.angielski) text.text = "Your father doesn't have a gun permit, the police pick him up, your mother gives you a PUNISHMENT (+ you have a poppy seed)";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_6)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Masz wyprany materac jednak rodzice sie o tym dowiedzieli masz KARE";
            if (buttons.angielski) text.text = "You have a washed mattress, however your parents found out about it --- you have PUNISHMENT";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_7)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Okazalo sie ze pani z pralni jest bliska przyjaciulka mamy i pozwala ci wyorac u niej materac za free a na dodatek nic nie muwi rodzicom nie masz KARY";
            if (buttons.angielski) text.text = "It turns out that the laundry lady is a close friend of mum's and lets you work out the mattress for free at her place, and on top of that she doesn't say anything to the parents --- you have no PUNISHMENT";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_8)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Wykonales zadania rodzice sa z ciebie dumni BRAWO";
            if (buttons.angielski) text.text = "You've done your job parents are proud of you --- BRAVO !!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_9)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Policja zlapala cie na braniu narkotykow pomimo iz nie jestes w wieku karalnym trafiasz do wiezienia!!!";
            if (buttons.angielski) text.text = "The police caught you taking drugs even though you are not of criminal age, you go to prison!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_10)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Patus wrucil aby sie zemscic UMIERASZ!!!";
            if (buttons.angielski) text.text = "Pathus came back to take revenge DYING!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_11)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Uciekles z miejsca zbrodni bez zacierania sladow, policja szybko wywnioskowala ze to twoja sprawka przez to ze nie jestes w wieku karalnym a bron byla twojego ojca idzie on do wiezienia!!!";
            if (buttons.angielski) text.text = "You fled the scene of the crime without covering your tracks, the police quickly concluded that it was your doing, because you are not of criminal age and your father's gun was going to prison!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_12)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Pomimo mlodego wieku udalo ci sie starannie zatrzec slady policja o niczym nie wiem jednak przesladuje coe duch zabitego przez ciebie patusa popelniasz samobojstwo!!!";
            if (buttons.angielski) text.text = "Despite your young age, you managed to carefully cover your tracks, the police don't know anything, but the ghost of the pathus you killed is haunting you, you commit suicide!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_13)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Okazalo sie ze ci nieznajomi to kosmici ktorzy poszukiwali obiektu badan nikt nie wie co sie z toba stalo oprocz ciebie samego";
            if (buttons.angielski) text.text = "It turned out that these strangers are aliens who were looking for the object of study, no one knows what happened to you except yourself";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_14)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Pomimo proby ucieczki kosmici cie zlapali i stales sie obiektem roznych testow teraz nikt oprocz ciebie nie wie co sie z toba dzieje";
            if (buttons.angielski) text.text = "Despite your attempt to escape, the aliens caught you and you became the subject of various tests, now no one but you knows what is happening to you";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_15)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Wpadles pod auto NIE ZYJESZ";
            if (buttons.angielski) text.text = "You fell under a car, YOU'RE DEAD";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_16)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            if (buttons.polski) text.text = "Pomomi tego iz udalo ci sie ukryc to ze obszczales materac to rodzice nie byli zadowoleni tym ze twuj brat gral caly dzien na twoim komputerze masz KARE!!!";
            if (buttons.polski) text.text = "If you managed to hide the fact that you on the mattress, your parents were not happy that your uncle brother played all day on your computer, you have KAR!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
    }

}
