using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class StatPreview : MonoBehaviour
{
    [Header("UI Container")]
    public GameObject uiPanel; // <--- VAR BARU: Masukkan objek 'ComparisonContainer' di sini

    [Header("UI References")]
    public TextMeshProUGUI dayText; 
    public TextMeshProUGUI beforeText;
    public TextMeshProUGUI afterText;

    [Header("Settings")]
    public bool isHireScene = false; 

    private int currentSurvival;
    private int monsterPower;

    void Start()
    {
        // 1. SEMBUNYIKAN PANEL DI AWAL
        if (uiPanel != null) uiPanel.SetActive(false);

        // Pengaman data dummy
        if (CommunityManager.members.Count == 0)
        {
            CommunityManager.ResetCommunity();
            WaveManager.ResetWave();
        }

        if (dayText != null) 
            dayText.text = "Day " + WaveManager.currentWave;

        CalculateBaseData();
        UpdateBeforeUI();
        
        if(afterText != null)
            afterText.text = "Select NPC to Fire...";
    }

    void CalculateBaseData()
    {
        monsterPower = WaveManager.GetMonsterStat();
        currentSurvival = 0;
        foreach (string member in CommunityManager.members)
        {
            if (CommunityManager.npcStats.ContainsKey(member))
            {
                currentSurvival += CommunityManager.npcStats[member].survival;
            }
        }
    }

    void UpdateBeforeUI()
    {
        float chance = CalculateChance(currentSurvival);
        beforeText.text = $"<size=120%><b>CURRENT TEAM</b></size>\n\n" +
                          $"Power: {currentSurvival}\n" +
                          $"Chance: {ColorChance(chance)}";
    }

    public void ShowPreview(string npcID)
    {
        // 2. TAMPILKAN PANEL SAAT TOMBOL DIKLIK
        if (uiPanel != null) uiPanel.SetActive(true);

        if (!CommunityManager.npcStats.ContainsKey(npcID)) return;

        int npcStat = CommunityManager.npcStats[npcID].survival;
        int projectedSurvival = 0;

        if (isHireScene)
        {
            projectedSurvival = currentSurvival + npcStat;
        }
        else
        {
            projectedSurvival = currentSurvival - npcStat;
            if (!string.IsNullOrEmpty(CommunityManager.hiredCandidate) && 
                CommunityManager.npcStats.ContainsKey(CommunityManager.hiredCandidate))
            {
                int replacementStat = CommunityManager.npcStats[CommunityManager.hiredCandidate].survival;
                projectedSurvival += replacementStat;
            }
        }

        float newChance = CalculateChance(projectedSurvival);
        string statColor = (projectedSurvival >= currentSurvival) ? "green" : "red";

        afterText.text = $"<size=120%><b>AFTER FIRE</b></size>\n\n" +
                         $"Power: <color={statColor}>{projectedSurvival}</color>\n" +
                         $"Chance: {ColorChance(newChance)}";
    }

    // Fungsi baru untuk menyembunyikan panel (dipanggil saat tombol Kembali)
    public void HidePreview()
    {
        if (uiPanel != null) uiPanel.SetActive(false);
    }

    float CalculateChance(int survival)
    {
        int total = survival + monsterPower;
        if (total == 0) return 0;
        return (float)survival / total * 100f;
    }

    string ColorChance(float chance)
    {
        string color = (chance >= 50) ? "green" : "red";
        return $"<color={color}>{chance:0}%</color>";
    }
}