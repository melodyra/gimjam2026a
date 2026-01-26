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

    public static string selectedNPC;

    void Start()
    {
        siluetpanel.SetActive(true);
        MatikanSemuaPanelNPC();
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
    }

    // --- FUNGSI BUTTON NPC ---

    public void NPC1Button()
    {
        selectedNPC = "NPC1";
        siluetpanel.SetActive(false);
        NPC1Panel.SetActive(true);
        resumepanelNPC1.SetActive(true);
        statsNPC1.SetActive(false);
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
    }
    public void detailNPC9()
    {
        resumepanelNPC9.SetActive(false);
        statsNPC9.SetActive(true);
    }

    // --- KEMBALI ---

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

        siluetpanel.SetActive(true);
        MatikanSemuaPanelNPC();
    }
}