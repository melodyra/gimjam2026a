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
    public static string selectedNPC;


    void Start()
    {
        siluetpanel.SetActive(true);
        mikupanel.SetActive(false);
        alaltenpanel.SetActive(false);
        sicbg3panel.SetActive(false);
    }
    void Update()
    {
        
    }
    public void mikubutton()
    {
        selectedNPC = "miku";
        siluetpanel.SetActive(false);
        mikupanel.SetActive(true);
        alaltenpanel.SetActive(false);
        sicbg3panel.SetActive(false);
        resumepanelmiku.SetActive(true);
        statsmiku.SetActive(false);
    }
    public void detailstatsmiku()
    {
        resumepanelmiku.SetActive(false);
        statsmiku.SetActive(true);
    }
    public void alaltenbutton()
    {
        selectedNPC = "alalten";
        siluetpanel.SetActive(false);
        mikupanel.SetActive(false);
        alaltenpanel.SetActive(true);
        sicbg3panel.SetActive(false);
        resumepanelalalten.SetActive(true);
        statsalalten.SetActive(false);
    }
    public void detailstatsalalten()
    {
        resumepanelalalten.SetActive(false);
        statsalalten.SetActive(true);
    }
    public void sicbg3()
    {
        selectedNPC = "sicbg3";
        siluetpanel.SetActive(false);
        mikupanel.SetActive(false);
        alaltenpanel.SetActive(false);
        sicbg3panel.SetActive(true);
        resumepanelsicbg3.SetActive(true);
        statssicbg3.SetActive(false);
    }
    public void detailstatssicbg3()
    {
        resumepanelsicbg3.SetActive(false);
        statssicbg3.SetActive(true);
    }
    public void kembali()
    {
        if (statsmiku.activeSelf)
        {
            statsmiku.SetActive(false);
            resumepanelmiku.SetActive(true);
            mikupanel.SetActive(true);
            return;
        }
        if (statsalalten.activeSelf)
        {
            statsalalten.SetActive(false);
            resumepanelalalten.SetActive(true);
            alaltenpanel.SetActive(true);
            return;
        }
        if (statssicbg3.activeSelf)
        {
            statssicbg3.SetActive(false);
            resumepanelsicbg3.SetActive(true);
            sicbg3panel.SetActive(true);
            return;
        }
        if (mikupanel.activeSelf || alaltenpanel.activeSelf || sicbg3panel.activeSelf)
        {
            siluetpanel.SetActive(true);

            mikupanel.SetActive(false);
            alaltenpanel.SetActive(false);
            sicbg3panel.SetActive(false);

            resumepanelmiku.SetActive(false);
            statsmiku.SetActive(false);

            resumepanelalalten.SetActive(false);
            statsalalten.SetActive(false);

            resumepanelsicbg3.SetActive(false);
            statssicbg3.SetActive(false);
        }
    }
}
