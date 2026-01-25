using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    [SerializeField] GameObject main_menu;
    [SerializeField] GameObject setting;
    [SerializeField] GameObject credit;
    [SerializeField] GameObject exit;
    public void Gotomenu (int id)
    {
        /* 
        ID Code:
        Main Menu : 0 
        Setting : 1
        Credit : 2
        Exit : 3
        */
        main_menu.SetActive(false);
        setting.SetActive(false);
        credit.SetActive(false);
        exit.SetActive(false);
        if(id == 0)
        {
            main_menu.SetActive(true);
        }
        if (id == 1)
        {
            setting.SetActive(true);
        }
        if (id == 2)
        {
            credit.SetActive(true);
        }
        if (id == 3)
        {
            exit.SetActive(true);
        }
    }
}
