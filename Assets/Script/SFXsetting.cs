using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SFXsetting : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    [SerializeField] Slider volume;
    void Start()
    {
        if (PlayerPrefs.HasKey("sfxvolume"))
        {
            Load();
        }
        else
        {
            PlayerPrefs.SetFloat("sfxvolume", 1);
            Load();
        }
    }
    public void changevolume()
    {
        sfx.volume = volume.value;
        Save();
    }
    private void Load()
    {
        volume.value = PlayerPrefs.GetFloat("sfxvolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("sfxvolume", volume.value);
    }
}
