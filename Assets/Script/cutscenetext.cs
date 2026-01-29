using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent1;
    public TextMeshProUGUI textComponent2;
    public string[] lines1;
    public string[] lines2;
    public AudioSource[] SFX;
    public float textSpeed;

    float volume;

    // Tambahkan ini agar bisa isi nama scene di Inspector
    public string namaSceneTujuan; 

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        volume = 1;
        if (PlayerPrefs.HasKey("sfxvolume"))
        {
            volume = PlayerPrefs.GetFloat("sfxvolume");
        }
        textComponent1.text = string.Empty;
        textComponent2.text = lines2[0];
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent1.text == lines1[index] && textComponent2.text == lines2[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent1.text = lines1[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        if(SFX[index] != null)
        {
            SFX[index].volume = volume;
            SFX[index].Play();
        }
        foreach (char c in lines1[index].ToCharArray())
        {
            textComponent1.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines1.Length - 1)
        {
            index++;
            textComponent1.text = string.Empty;
            textComponent2.text = lines2[index];
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(namaSceneTujuan); 
        }
    }
}