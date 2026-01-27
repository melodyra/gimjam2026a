using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Volumesetting : MonoBehaviour
{   
    [SerializeField] Slider volume;
    [SerializeField] AudioSource bgm;
    void Start()
    {
        if (PlayerPrefs.HasKey("musicvolume"))
        {
            Load();
        }
        else
        {
            PlayerPrefs.SetFloat("musicvolume", 1);
            Load();
        }
    }
    public void changevolume()
    {
        bgm.volume = volume.value;
        Save();
    }
    private void Load()
    {
        volume.value = PlayerPrefs.GetFloat("musicvolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicvolume", volume.value);
    }
}
