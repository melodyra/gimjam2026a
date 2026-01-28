using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject siluetpanel;

    [Header("NPC 1")]
    public GameObject NPC1Panel;
    public GameObject resumepanelNPC1;
    public GameObject statsNPC1;

    [Header("NPC 2")]
    public GameObject NPC2Panel;
    public GameObject resumepanelNPC2;
    public GameObject statsNPC2;

    [Header("NPC 3")]
    public GameObject NPC3Panel;
    public GameObject resumepanelNPC3;
    public GameObject statsNPC3;

    [Header("NPC 4")]
    public GameObject NPC4Panel;
    public GameObject resumepanelNPC4;
    public GameObject statsNPC4;

    [Header("NPC 5")]
    public GameObject NPC5Panel;
    public GameObject resumepanelNPC5;
    public GameObject statsNPC5;

    [Header("NPC 6")]
    public GameObject NPC6Panel;
    public GameObject resumepanelNPC6;
    public GameObject statsNPC6;

    [Header("NPC 7")]
    public GameObject NPC7Panel;
    public GameObject resumepanelNPC7;
    public GameObject statsNPC7;

    [Header("NPC 8")]
    public GameObject NPC8Panel;
    public GameObject resumepanelNPC8;
    public GameObject statsNPC8;

    [Header("NPC 9")]
    public GameObject NPC9Panel;
    public GameObject resumepanelNPC9;
    public GameObject statsNPC9;

    [Header("NPC 10")]
    public GameObject NPC10Panel;
    public GameObject resumepanelNPC10;
    public GameObject statsNPC10;

    [Header("NPC Miku")]
    public GameObject mikuPanel;
    public GameObject resumepanelmiku;
    public GameObject statsmiku;

    [Header("NPC Alalten")]
    public GameObject alaltenPanel;
    public GameObject resumepanelalalten;
    public GameObject statsalalten;

    [Header("NPC Sicbg3")]
    public GameObject sicbg3Panel;
    public GameObject resumepanelsicbg3;
    public GameObject statssicbg3;

    [Header("NPC 14")]
    public GameObject NPC14Panel;
    public GameObject resumepanelNPC14;
    public GameObject statsNPC14;

    [Header("NPC 15")]
    public GameObject NPC15Panel;
    public GameObject resumepanelNPC15;
    public GameObject statsNPC15;

    [Header("NPC 16")]
    public GameObject NPC16Panel;
    public GameObject resumepanelNPC16;
    public GameObject statsNPC16;

    [Header("NPC 17")]
    public GameObject NPC17Panel;
    public GameObject resumepanelNPC17;
    public GameObject statsNPC17;

    [Header("NPC 18")]
    public GameObject NPC18Panel;
    public GameObject resumepanelNPC18;
    public GameObject statsNPC18;

    [Header("NPC 19")]
    public GameObject NPC19Panel;
    public GameObject resumepanelNPC19;
    public GameObject statsNPC19;

    public static string selectedNPC;
    public GameObject TutorialPopUp;
    public TutorialFireController tutorialScript;
    public static bool sudahSelesaiTutorial = false;
    

    void Start()
    {
        siluetpanel.SetActive(true);
        TutorialPopUp.SetActive(true);
        MatikanSemuaPanelNPC();
        if (sudahSelesaiTutorial)
        {
            if(TutorialPopUp != null) TutorialPopUp.SetActive(false);
        }
        else
        {
            if(TutorialPopUp != null) TutorialPopUp.SetActive(true);
        }
    }

    private void MatikanSemuaPanelNPC()
    {
        NPC1Panel.SetActive(false);
        NPC2Panel.SetActive(false);
        NPC3Panel.SetActive(false);
        NPC4Panel.SetActive(false);
        NPC5Panel.SetActive(false);
        NPC6Panel.SetActive(false);
        NPC7Panel.SetActive(false);
        NPC8Panel.SetActive(false);
        NPC9Panel.SetActive(false);
        NPC10Panel.SetActive(false);
        mikuPanel.SetActive(false);
        alaltenPanel.SetActive(false);
        sicbg3Panel.SetActive(false);
        NPC14Panel.SetActive(false);
        NPC15Panel.SetActive(false);
        NPC16Panel.SetActive(false);
        NPC17Panel.SetActive(false);
        NPC18Panel.SetActive(false);
        NPC19Panel.SetActive(false);
    }

    public void NPC1Button()
    {
        selectedNPC = "NPC1";
        siluetpanel.SetActive(false);
        NPC1Panel.SetActive(true);
        resumepanelNPC1.SetActive(true);
        statsNPC1.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC1()
    {
        resumepanelNPC1.SetActive(false);
        statsNPC1.SetActive(true);
    }

    public void NPC2Button()
    {
        selectedNPC = "NPC2";
        siluetpanel.SetActive(false);
        NPC2Panel.SetActive(true);
        resumepanelNPC2.SetActive(true);
        statsNPC2.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC2()
    {
        resumepanelNPC2.SetActive(false);
        statsNPC2.SetActive(true);
    }

    public void NPC3Button()
    {
        selectedNPC = "NPC3";
        siluetpanel.SetActive(false);
        NPC3Panel.SetActive(true);
        resumepanelNPC3.SetActive(true);
        statsNPC3.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC3()
    {
        resumepanelNPC3.SetActive(false);
        statsNPC3.SetActive(true);
    }

    public void NPC4Button()
    {
        selectedNPC = "NPC4";
        siluetpanel.SetActive(false);
        NPC4Panel.SetActive(true);
        resumepanelNPC4.SetActive(true);
        statsNPC4.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC4()
    {
        resumepanelNPC4.SetActive(false);
        statsNPC4.SetActive(true);
    }

    public void NPC5Button()
    {
        selectedNPC = "NPC5";
        siluetpanel.SetActive(false);
        NPC5Panel.SetActive(true);
        resumepanelNPC5.SetActive(true);
        statsNPC5.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC5()
    {
        resumepanelNPC5.SetActive(false);
        statsNPC5.SetActive(true);
    }

    public void NPC6Button()
    {
        selectedNPC = "NPC6";
        siluetpanel.SetActive(false);
        NPC6Panel.SetActive(true);
        resumepanelNPC6.SetActive(true);
        statsNPC6.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC6()
    {
        resumepanelNPC6.SetActive(false);
        statsNPC6.SetActive(true);
    }

    public void NPC7Button()
    {
        selectedNPC = "NPC7";
        siluetpanel.SetActive(false);
        NPC7Panel.SetActive(true);
        resumepanelNPC7.SetActive(true);
        statsNPC7.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC7()
    {
        resumepanelNPC7.SetActive(false);
        statsNPC7.SetActive(true);
    }

    public void NPC8Button()
    {
        selectedNPC = "NPC8";
        siluetpanel.SetActive(false);
        NPC8Panel.SetActive(true);
        resumepanelNPC8.SetActive(true);
        statsNPC8.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC8()
    {
        resumepanelNPC8.SetActive(false);
        statsNPC8.SetActive(true);
    }

    public void NPC9Button()
    {
        selectedNPC = "NPC9";
        siluetpanel.SetActive(false);
        NPC9Panel.SetActive(true);
        resumepanelNPC9.SetActive(true);
        statsNPC9.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC9()
    {
        resumepanelNPC9.SetActive(false);
        statsNPC9.SetActive(true);
    }

    public void NPC10Button()
    {
        selectedNPC = "NPC10";
        siluetpanel.SetActive(false);
        NPC10Panel.SetActive(true);
        resumepanelNPC10.SetActive(true);
        statsNPC10.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC10()
    {
        resumepanelNPC10.SetActive(false);
        statsNPC10.SetActive(true);
    }

    public void mikuButton()
    {
        selectedNPC = "miku";
        siluetpanel.SetActive(false);
        mikuPanel.SetActive(true);
        resumepanelmiku.SetActive(true);
        statsmiku.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailmiku()
    {
        resumepanelmiku.SetActive(false);
        statsmiku.SetActive(true);
    }

    public void alaltenButton()
    {
        selectedNPC = "alalten";
        siluetpanel.SetActive(false);
        alaltenPanel.SetActive(true);
        resumepanelalalten.SetActive(true);
        statsalalten.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailalalten()
    {
        resumepanelalalten.SetActive(false);
        statsalalten.SetActive(true);
    }
    public void sicbg3Button()
    {
        selectedNPC = "sicbg3";
        siluetpanel.SetActive(false);
        sicbg3Panel.SetActive(true);
        resumepanelsicbg3.SetActive(true);
        statssicbg3.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailsicbg3()
    {
        resumepanelsicbg3.SetActive(false);
        statssicbg3.SetActive(true);
    }

    public void NPC14Button()
    {
        selectedNPC = "NPC14";
        siluetpanel.SetActive(false);
        NPC14Panel.SetActive(true);
        resumepanelNPC14.SetActive(true);
        statsNPC14.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC14()
    {
        resumepanelNPC14.SetActive(false);
        statsNPC14.SetActive(true);
    }

    public void NPC15Button()
    {
        selectedNPC = "NPC15";
        siluetpanel.SetActive(false);
        NPC15Panel.SetActive(true);
        resumepanelNPC15.SetActive(true);
        statsNPC15.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC15()
    {
        resumepanelNPC15.SetActive(false);
        statsNPC15.SetActive(true);
    }

    public void NPC16Button()
    {
        selectedNPC = "NPC16";
        siluetpanel.SetActive(false);
        NPC16Panel.SetActive(true);
        resumepanelNPC16.SetActive(true);
        statsNPC16.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC16()
    {
        resumepanelNPC16.SetActive(false);
        statsNPC16.SetActive(true);
    }

    public void NPC17Button()
    {
        selectedNPC = "NPC17";
        siluetpanel.SetActive(false);
        NPC17Panel.SetActive(true);
        resumepanelNPC17.SetActive(true);
        statsNPC17.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC17()
    {
        resumepanelNPC17.SetActive(false);
        statsNPC17.SetActive(true);
    }

    public void NPC18Button()
    {
        selectedNPC = "NPC18";
        siluetpanel.SetActive(false);
        NPC18Panel.SetActive(true);
        resumepanelNPC18.SetActive(true);
        statsNPC18.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC18()
    {
        resumepanelNPC18.SetActive(false);
        statsNPC18.SetActive(true);
    }

    public void NPC19Button()
    {
        selectedNPC = "NPC19";
        siluetpanel.SetActive(false);
        NPC19Panel.SetActive(true);
        resumepanelNPC19.SetActive(true);
        statsNPC19.SetActive(false);
        if (tutorialScript != null) 
    {
        tutorialScript.StartTutorialSequence();
    }
    }
    public void detailNPC19()
    {
        resumepanelNPC19.SetActive(false);
        statsNPC19.SetActive(true);
    }


    public void kembali()
    {
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
        if (statsmiku.activeSelf) { statsmiku.SetActive(false); resumepanelmiku.SetActive(true); return; }
        if (statsalalten.activeSelf) { statsalalten.SetActive(false); resumepanelalalten.SetActive(true); return; }
        if (statssicbg3.activeSelf) { statssicbg3.SetActive(false); resumepanelsicbg3.SetActive(true); return; }
        if (statsNPC14.activeSelf) { statsNPC14.SetActive(false); resumepanelNPC14.SetActive(true); return; }
        if (statsNPC15.activeSelf) { statsNPC15.SetActive(false); resumepanelNPC15.SetActive(true); return; }
        if (statsNPC16.activeSelf) { statsNPC16.SetActive(false); resumepanelNPC16.SetActive(true); return; }
        if (statsNPC17.activeSelf) { statsNPC17.SetActive(false); resumepanelNPC17.SetActive(true); return; }
        if (statsNPC18.activeSelf) { statsNPC18.SetActive(false); resumepanelNPC18.SetActive(true); return; }
        if (statsNPC19.activeSelf) { statsNPC19.SetActive(false); resumepanelNPC19.SetActive(true); return; }

        siluetpanel.SetActive(true);
        MatikanSemuaPanelNPC();
    }
}