using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] lines1;
    public GameObject Pause_Menu;
    public void pausing()
    {
        Pause_Menu.SetActive(true);
        for(int i = 0; i < lines1.Length; i++)
        {
            lines1[i].SetActive(false);
        }
    }
    public void resume(){
        Pause_Menu.SetActive(false);
        for(int i = 0; i < lines1.Length; i++)
        {
            lines1[i].SetActive(true);
        }
    }
}
