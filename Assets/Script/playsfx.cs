using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsfx : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    float volumesuara = 0;
    public void play()
    {
        if (PlayerPrefs.HasKey("sfxvolume"))
        {
            volumesuara = PlayerPrefs.GetFloat("sfxvolume");
        }
        sfx.volume = volumesuara;
        sfx.Play();
    }
}
