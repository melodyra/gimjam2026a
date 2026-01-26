using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HireController : MonoBehaviour
{
    public GameObject siluetpanel;

    // ===== NPC AWAL =====
    public GameObject mikupanel;
    public GameObject resumepanelmiku;
    public GameObject statsmiku;

    public GameObject alaltenpanel;
    public GameObject resumepanelalalten;
    public GameObject statsalalten;

    public GameObject sicbg3panel;
    public GameObject resumepanelsicbg3;
    public GameObject statssicbg3;

    // ===== NPC 14 - 19 =====
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

    public static string selectedNPC;

    void Start()
    {
        siluetpanel.SetActive(true);

        mikupanel.SetActive(false);
        alaltenpanel.SetActive(false);
        sicbg3panel.SetActive(false);

        NPC14panel.SetActive(false);
        NPC15panel.SetActive(false);
        NPC16panel.SetActive(false);
        NPC17panel.SetActive(false);
        NPC18panel.SetActive(false);
        NPC19panel.SetActive(false);
    }

    // ===== MIKU =====
    public void mikubutton()
    {
        selectedNPC = "miku";
        HideAll();
        mikupanel.SetActive(true);
        resumepanelmiku.SetActive(true);
        statsmiku.SetActive(false);
    }

    public void detailstatsmiku()
    {
        resumepanelmiku.SetActive(false);
        statsmiku.SetActive(true);
    }

    // ===== ALALTEN =====
    public void alaltenbutton()
    {
        selectedNPC = "alalten";
        HideAll();
        alaltenpanel.SetActive(true);
        resumepanelalalten.SetActive(true);
        statsalalten.SetActive(false);
    }

    public void detailstatsalalten()
    {
        resumepanelalalten.SetActive(false);
        statsalalten.SetActive(true);
    }

    // ===== SICBG3 =====
    public void sicbg3button()
    {
        selectedNPC = "sicbg3";
        HideAll();
        sicbg3panel.SetActive(true);
        resumepanelsicbg3.SetActive(true);
        statssicbg3.SetActive(false);
    }

    public void detailstatssicbg3()
    {
        resumepanelsicbg3.SetActive(false);
        statssicbg3.SetActive(true);
    }

    // ===== NPC14 =====
    public void NPC14button()
    {
        selectedNPC = "NPC14";
        HideAll();
        NPC14panel.SetActive(true);
        resumepanelNPC14.SetActive(true);
        statsNPC14.SetActive(false);
    }

    public void detailstatsNPC14()
    {
        resumepanelNPC14.SetActive(false);
        statsNPC14.SetActive(true);
    }

    // ===== NPC15 =====
    public void NPC15button()
    {
        selectedNPC = "NPC15";
        HideAll();
        NPC15panel.SetActive(true);
        resumepanelNPC15.SetActive(true);
        statsNPC15.SetActive(false);
    }

    public void detailstatsNPC15()
    {
        resumepanelNPC15.SetActive(false);
        statsNPC15.SetActive(true);
    }

    // ===== NPC16 =====
    public void NPC16button()
    {
        selectedNPC = "NPC16";
        HideAll();
        NPC16panel.SetActive(true);
        resumepanelNPC16.SetActive(true);
        statsNPC16.SetActive(false);
    }

    public void detailstatsNPC16()
    {
        resumepanelNPC16.SetActive(false);
        statsNPC16.SetActive(true);
    }

    // ===== NPC17 =====
    public void NPC17button()
    {
        selectedNPC = "NPC17";
        HideAll();
        NPC17panel.SetActive(true);
        resumepanelNPC17.SetActive(true);
        statsNPC17.SetActive(false);
    }

    public void detailstatsNPC17()
    {
        resumepanelNPC17.SetActive(false);
        statsNPC17.SetActive(true);
    }

    // ===== NPC18 =====
    public void NPC18button()
    {
        selectedNPC = "NPC18";
        HideAll();
        NPC18panel.SetActive(true);
        resumepanelNPC18.SetActive(true);
        statsNPC18.SetActive(false);
    }

    public void detailstatsNPC18()
    {
        resumepanelNPC18.SetActive(false);
        statsNPC18.SetActive(true);
    }

    // ===== NPC19 =====
    public void NPC19button()
    {
        selectedNPC = "NPC19";
        HideAll();
        NPC19panel.SetActive(true);
        resumepanelNPC19.SetActive(true);
        statsNPC19.SetActive(false);
    }

    public void detailstatsNPC19()
    {
        resumepanelNPC19.SetActive(false);
        statsNPC19.SetActive(true);
    }

    // ===== KEMBALI =====
    public void kembali()
    {
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