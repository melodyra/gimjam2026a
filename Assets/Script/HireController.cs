using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HireController : MonoBehaviour
{
    public GameObject siluetpanel;
    public GameObject mikupanel;
    public GameObject resumepanelmiku;
    public GameObject statsmiku;
    public GameObject alaltenpanel;
    public GameObject resumepanelalalten;
    public GameObject statsalalten;
    public GameObject sicbg3panel;
    public GameObject resumepanelsicbg3;
    public GameObject statssicbg3;
    public GameObject NPC1panel;
    public GameObject resumepanelNPC1;
    public GameObject statsNPC1;
    public GameObject NPC2panel;
    public GameObject resumepanelNPC2;
    public GameObject statsNPC2;
    public GameObject NPC3panel;
    public GameObject resumepanelNPC3;
    public GameObject statsNPC3;
    public GameObject NPC4panel;
    public GameObject resumepanelNPC4;
    public GameObject statsNPC4;
    public GameObject NPC5panel;
    public GameObject resumepanelNPC5;
    public GameObject statsNPC5;
    public GameObject NPC6panel;
    public GameObject resumepanelNPC6;
    public GameObject statsNPC6;
    public GameObject NPC7panel;
    public GameObject resumepanelNPC7;
    public GameObject statsNPC7;
    public GameObject NPC8panel;
    public GameObject resumepanelNPC8;
    public GameObject statsNPC8;
    public GameObject NPC9panel;
    public GameObject resumepanelNPC9;
    public GameObject statsNPC9;
    public GameObject NPC10panel;
    public GameObject resumepanelNPC10;
    public GameObject statsNPC10;
    public GameObject NPC14panel;
    public GameObject resumepanelNPC14;
    public GameObject statsNPC14;
    public GameObject NPC15panel;
    public GameObject resumepanelNPC15;
    public GameObject statsNPC15;
    public GameObject NPC16panel;
    public GameObject resumepanelNPC16;
    public GameObject statsNPC16;
    public GameObject NPC17panel;
    public GameObject resumepanelNPC17;
    public GameObject statsNPC17;
    public GameObject NPC18panel;
    public GameObject resumepanelNPC18;
    public GameObject statsNPC18;
    public GameObject NPC19panel;
    public GameObject resumepanelNPC19;
    public GameObject statsNPC19;
    public GameObject TutorialPopUp;
    public static bool sudahSelesaiTutorial = false;
    

    public static string selectedNPC;
    
    public TutorialHireController tutorialScript;

    void Start()
    {
        TutorialPopUp.SetActive(true);
        siluetpanel.SetActive(true);

        mikupanel.SetActive(false);
        alaltenpanel.SetActive(false);
        sicbg3panel.SetActive(false);

        NPC1panel.SetActive(false);
        NPC2panel.SetActive(false);
        NPC3panel.SetActive(false);
        NPC4panel.SetActive(false);
        NPC5panel.SetActive(false);
        NPC6panel.SetActive(false);
        NPC7panel.SetActive(false);
        NPC8panel.SetActive(false);
        NPC9panel.SetActive(false);
        NPC10panel.SetActive(false);
        NPC14panel.SetActive(false);
        NPC15panel.SetActive(false);
        NPC16panel.SetActive(false);
        NPC17panel.SetActive(false);
        NPC18panel.SetActive(false);
        NPC19panel.SetActive(false);

        if (sudahSelesaiTutorial)
        {
        if(TutorialPopUp != null) TutorialPopUp.SetActive(false);
        }
        else
        {
        if(TutorialPopUp != null) TutorialPopUp.SetActive(true);
        }
    }

    public void SetTutorialFinished()
    {
        sudahSelesaiTutorial = true;
        if(TutorialPopUp != null) TutorialPopUp.SetActive(false);
    }

    public void mikubutton()
    {
        selectedNPC = "miku";
        HideAll();
        mikupanel.SetActive(true);
        resumepanelmiku.SetActive(true);
        statsmiku.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsmiku()
    {
        resumepanelmiku.SetActive(false);
        statsmiku.SetActive(true);
    }

    public void alaltenbutton()
    {
        selectedNPC = "alalten";
        HideAll();
        alaltenpanel.SetActive(true);
        resumepanelalalten.SetActive(true);
        statsalalten.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsalalten()
    {
        resumepanelalalten.SetActive(false);
        statsalalten.SetActive(true);
    }

    public void sicbg3button()
    {
        selectedNPC = "sicbg3";
        HideAll();
        sicbg3panel.SetActive(true);
        resumepanelsicbg3.SetActive(true);
        statssicbg3.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatssicbg3()
    {
        resumepanelsicbg3.SetActive(false);
        statssicbg3.SetActive(true);
    }

    public void NPC1button()
    {
        selectedNPC = "NPC1";
        HideAll();
        NPC1panel.SetActive(true);
        resumepanelNPC1.SetActive(true);
        statsNPC1.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC1()
    {
        resumepanelNPC1.SetActive(false);
        statsNPC1.SetActive(true);
    }

    public void NPC2button()
    {
        selectedNPC = "NPC2";
        HideAll();
        NPC2panel.SetActive(true);
        resumepanelNPC2.SetActive(true);
        statsNPC2.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC2()
    {
        resumepanelNPC2.SetActive(false);
        statsNPC2.SetActive(true);
    }

    public void NPC3button()
    {
        selectedNPC = "NPC3";
        HideAll();
        NPC3panel.SetActive(true);
        resumepanelNPC3.SetActive(true);
        statsNPC3.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC3()
    {
        resumepanelNPC3.SetActive(false);
        statsNPC3.SetActive(true);
    }

    public void NPC4button()
    {
        selectedNPC = "NPC4";
        HideAll();
        NPC4panel.SetActive(true);
        resumepanelNPC4.SetActive(true);
        statsNPC4.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC4()
    {
        resumepanelNPC4.SetActive(false);
        statsNPC4.SetActive(true);
    }

    public void NPC5button()
    {
        selectedNPC = "NPC5";
        HideAll();
        NPC5panel.SetActive(true);
        resumepanelNPC5.SetActive(true);
        statsNPC5.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC5()
    {
        resumepanelNPC5.SetActive(false);
        statsNPC5.SetActive(true);
    }

    public void NPC6button()
    {
        selectedNPC = "NPC6";
        HideAll();
        NPC6panel.SetActive(true);
        resumepanelNPC6.SetActive(true);
        statsNPC6.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC6()
    {
        resumepanelNPC6.SetActive(false);
        statsNPC6.SetActive(true);
    }

    public void NPC7button()
    {
        selectedNPC = "NPC7";
        HideAll();
        NPC7panel.SetActive(true);
        resumepanelNPC7.SetActive(true);
        statsNPC7.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC7()
    {
        resumepanelNPC7.SetActive(false);
        statsNPC7.SetActive(true);
    }

    public void NPC8button()
    {
        selectedNPC = "NPC8";
        HideAll();
        NPC8panel.SetActive(true);
        resumepanelNPC8.SetActive(true);
        statsNPC8.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC8()
    {
        resumepanelNPC8.SetActive(false);
        statsNPC8.SetActive(true);
    }

    public void NPC9button()
    {
        selectedNPC = "NPC9";
        HideAll();
        NPC9panel.SetActive(true);
        resumepanelNPC9.SetActive(true);
        statsNPC9.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC9()
    {
        resumepanelNPC9.SetActive(false);
        statsNPC9.SetActive(true);
    }

    public void NPC10button()
    {
        selectedNPC = "NPC10";
        HideAll();
        NPC10panel.SetActive(true);
        resumepanelNPC10.SetActive(true);
        statsNPC10.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC10()
    {
        resumepanelNPC10.SetActive(false);
        statsNPC10.SetActive(true);
    }

    public void NPC14button()
    {
        selectedNPC = "NPC14";
        HideAll();
        NPC14panel.SetActive(true);
        resumepanelNPC14.SetActive(true);
        statsNPC14.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC14()
    {
        resumepanelNPC14.SetActive(false);
        statsNPC14.SetActive(true);
    }

    public void NPC15button()
    {
        selectedNPC = "NPC15";
        HideAll();
        NPC15panel.SetActive(true);
        resumepanelNPC15.SetActive(true);
        statsNPC15.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC15()
    {
        resumepanelNPC15.SetActive(false);
        statsNPC15.SetActive(true);
    }

    public void NPC16button()
    {
        selectedNPC = "NPC16";
        HideAll();
        NPC16panel.SetActive(true);
        resumepanelNPC16.SetActive(true);
        statsNPC16.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC16()
    {
        resumepanelNPC16.SetActive(false);
        statsNPC16.SetActive(true);
    }

    public void NPC17button()
    {
        selectedNPC = "NPC17";
        HideAll();
        NPC17panel.SetActive(true);
        resumepanelNPC17.SetActive(true);
        statsNPC17.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC17()
    {
        resumepanelNPC17.SetActive(false);
        statsNPC17.SetActive(true);
    }

    public void NPC18button()
    {
        selectedNPC = "NPC18";
        HideAll();
        NPC18panel.SetActive(true);
        resumepanelNPC18.SetActive(true);
        statsNPC18.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC18()
    {
        resumepanelNPC18.SetActive(false);
        statsNPC18.SetActive(true);
    }

    public void NPC19button()
    {
        selectedNPC = "NPC19";
        HideAll();
        NPC19panel.SetActive(true);
        resumepanelNPC19.SetActive(true);
        statsNPC19.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }

    public void detailstatsNPC19()
    {
        resumepanelNPC19.SetActive(false);
        statsNPC19.SetActive(true);
    }

    public void kembali()
    {
        if (statsmiku.activeSelf) { statsmiku.SetActive(false); resumepanelmiku.SetActive(true); return; }
        if (statsalalten.activeSelf) { statsalalten.SetActive(false); resumepanelalalten.SetActive(true); return; }
        if (statssicbg3.activeSelf) { statssicbg3.SetActive(false); resumepanelsicbg3.SetActive(true); return; }
        
        if (statsNPC1.activeSelf) { statsNPC1.SetActive(false); resumepanelNPC1.SetActive(true); return; }
        if (statsNPC2.activeSelf) { statsNPC2.SetActive(false); resumepanelNPC2.SetActive(true); return; }
        if (statsNPC3.activeSelf) { statsNPC3.SetActive(false); resumepanelNPC3.SetActive(true); return; }
        if (statsNPC4.activeSelf) { statsNPC4.SetActive(false); resumepanelNPC4.SetActive(true); return; }
        if (statsNPC5.activeSelf) { statsNPC5.SetActive(false); resumepanelNPC5.SetActive(true); return; }
        if (statsNPC6.activeSelf) { statsNPC6.SetActive(false); resumepanelNPC6.SetActive(true); return; }
        if (statsNPC7.activeSelf) { statsNPC7.SetActive(false); resumepanelNPC7.SetActive(true); return; }
        if (statsNPC8.activeSelf) { statsNPC8.SetActive(false); resumepanelNPC8.SetActive(true); return; }
        if (statsNPC9.activeSelf) { statsNPC9.SetActive(false); resumepanelNPC9.SetActive(true); return; }
        if (statsNPC10.activeSelf) { statsNPC10.SetActive(false); resumepanelNPC10.SetActive(true); return; }
        
        if (statsNPC14.activeSelf) { statsNPC14.SetActive(false); resumepanelNPC14.SetActive(true); return; }
        if (statsNPC15.activeSelf) { statsNPC15.SetActive(false); resumepanelNPC15.SetActive(true); return; }
        if (statsNPC16.activeSelf) { statsNPC16.SetActive(false); resumepanelNPC16.SetActive(true); return; }
        if (statsNPC17.activeSelf) { statsNPC17.SetActive(false); resumepanelNPC17.SetActive(true); return; }
        if (statsNPC18.activeSelf) { statsNPC18.SetActive(false); resumepanelNPC18.SetActive(true); return; }
        if (statsNPC19.activeSelf) { statsNPC19.SetActive(false); resumepanelNPC19.SetActive(true); return; }

        HideAll();
        siluetpanel.SetActive(true);
        selectedNPC = "";
    }

    void HideAll()
    { 
        siluetpanel.SetActive(false);

        mikupanel.SetActive(false);
        alaltenpanel.SetActive(false);
        sicbg3panel.SetActive(false);

        NPC1panel.SetActive(false);
        NPC2panel.SetActive(false);
        NPC3panel.SetActive(false);
        NPC4panel.SetActive(false);
        NPC5panel.SetActive(false);
        NPC6panel.SetActive(false);
        NPC7panel.SetActive(false);
        NPC8panel.SetActive(false);
        NPC9panel.SetActive(false);
        NPC10panel.SetActive(false);
        NPC14panel.SetActive(false);
        NPC15panel.SetActive(false);
        NPC16panel.SetActive(false);
        NPC17panel.SetActive(false);
        NPC18panel.SetActive(false);
        NPC19panel.SetActive(false);

        resumepanelmiku.SetActive(false);
        statsmiku.SetActive(false);
        resumepanelalalten.SetActive(false);
        statsalalten.SetActive(false);
        resumepanelsicbg3.SetActive(false);
        statssicbg3.SetActive(false);

        resumepanelNPC1.SetActive(false);
        statsNPC1.SetActive(false);
        resumepanelNPC2.SetActive(false);
        statsNPC2.SetActive(false);
        resumepanelNPC3.SetActive(false);
        statsNPC3.SetActive(false);
        resumepanelNPC4.SetActive(false);
        statsNPC4.SetActive(false);
        resumepanelNPC5.SetActive(false);
        statsNPC5.SetActive(false);
        resumepanelNPC6.SetActive(false);
        statsNPC6.SetActive(false);
        resumepanelNPC7.SetActive(false);
        statsNPC7.SetActive(false);
        resumepanelNPC8.SetActive(false);
        statsNPC8.SetActive(false);
        resumepanelNPC9.SetActive(false);
        statsNPC9.SetActive(false);
        resumepanelNPC10.SetActive(false);
        statsNPC10.SetActive(false);

        resumepanelNPC14.SetActive(false);
        statsNPC14.SetActive(false);
        resumepanelNPC15.SetActive(false);
        statsNPC15.SetActive(false);
        resumepanelNPC16.SetActive(false);
        statsNPC16.SetActive(false);
        resumepanelNPC17.SetActive(false);
        statsNPC17.SetActive(false);
        resumepanelNPC18.SetActive(false);
        statsNPC18.SetActive(false);
        resumepanelNPC19.SetActive(false);
        statsNPC19.SetActive(false);
    }
}