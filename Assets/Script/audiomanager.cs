using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource SFX;
    void Start()
    {
        float val1 = 1;
        float val2 = 1;
        if (PlayerPrefs.HasKey("musicvolume"))
        {
            val1 = PlayerPrefs.GetFloat("musicvolume");
        }
        if (PlayerPrefs.HasKey("sfxvolume"))
        {
            val2 = PlayerPrefs.GetFloat("sfxvolume");
        }
        SFX.volume = val2;
        BGM.volume = val1;
        
    }
    
}
