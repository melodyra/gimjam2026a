using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXsetting : MonoBehaviour
{
    [SerializeField] Slider volume;
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
        AudioListener.volume = volume.value;
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
