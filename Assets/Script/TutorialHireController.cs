using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialHireController : MonoBehaviour
{
    [Header("Panel Tutorial (Urutkan 1-6)")]
    public GameObject[] tutorialPanels; 
    
    [Header("Blocker Input")]
    public GameObject inputBlocker;
    public GameObject skiptutorial;

    private int currentStep = 0;
    private bool tutorialStarted = false;

    void Start()
    {
        HideAll();
        skiptutorial.SetActive(true);
        if (tutorialPanels.Length > 0)
        {
            tutorialPanels[0].SetActive(true);
        }
        
        if(inputBlocker != null) inputBlocker.SetActive(false);
    }

    public void SkipTutorial()
    {
        tutorialStarted = true;
        FinishTutorial();
        skiptutorial.SetActive(false);
    }

    public void StartTutorialSequence()
    {
        if (tutorialStarted) return; 

        tutorialStarted = true;
        
        if (tutorialPanels.Length > 0) tutorialPanels[0].SetActive(false);

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
        HireController.sudahSelesaiTutorial = true; 
        
        HideAll();
        if(inputBlocker != null) inputBlocker.SetActive(false);
        if(skiptutorial != null) skiptutorial.SetActive(false);
        
        this.gameObject.SetActive(false); 
    }

    void HideAll()
    {
        foreach (var p in tutorialPanels)
        {
            if (p != null) p.SetActive(false);
        }
    }
}