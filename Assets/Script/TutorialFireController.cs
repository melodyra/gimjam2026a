using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialFireController : MonoBehaviour
{
    [Header("Panel Tutorial (Isi 3 Saja)")]
    public GameObject[] tutorialPanels; 
    
    [Header("References")]
    public GameObject inputBlocker;
    public GameObject skiptutorial;
    public GameObject TutorialPopUp;

    private int currentStep = 0;
    private bool tutorialStarted = false;

    void Start()
    {
        // Cek dulu ke FireController apakah sudah pernah selesai
        if (FireController.sudahSelesaiTutorial)
        {
            if (TutorialPopUp != null) TutorialPopUp.SetActive(false);
            return;
        }

        if(TutorialPopUp != null) TutorialPopUp.SetActive(true);
        
        HideAll();
        
        if (skiptutorial != null) skiptutorial.SetActive(true);
        
        if (tutorialPanels.Length > 0)
        {
            tutorialPanels[0].SetActive(true);
        }
        
        if(inputBlocker != null) inputBlocker.SetActive(false);
    }

    public void SkipTutorial()
    {
        FinishTutorial();
    }

    public void StartTutorialSequence()
    {
        if (tutorialStarted || FireController.sudahSelesaiTutorial) return; 

        tutorialStarted = true;
        
        // Matikan panel pertama (petunjuk klik NPC)
        if (tutorialPanels.Length > 0) tutorialPanels[0].SetActive(false);

        // Masuk ke panel tutorial berikutnya (indeks 1)
        currentStep = 1; 
        if (currentStep < tutorialPanels.Length)
        {
            tutorialPanels[currentStep].SetActive(true);
        }

        if(inputBlocker != null) inputBlocker.SetActive(true);
    }

    public void NextTutorial()
    {
        if (currentStep < tutorialPanels.Length)
        {
            tutorialPanels[currentStep].SetActive(false);
        }

        currentStep++;

        if (currentStep < tutorialPanels.Length)
        {
            tutorialPanels[currentStep].SetActive(true);
        }
        else
        {
            FinishTutorial();
        }
    }

    public void FinishTutorial()
    {
        FireController.sudahSelesaiTutorial = true; 
        
        HideAll();
        
        if(inputBlocker != null) inputBlocker.SetActive(false);
        if(skiptutorial != null) skiptutorial.SetActive(false);
        if(TutorialPopUp != null) TutorialPopUp.SetActive(false);
    }

    void HideAll()
    {
        foreach (var p in tutorialPanels)
        {
            if (p != null) p.SetActive(false);
        }
    }
}