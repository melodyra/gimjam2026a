using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TeamStatsDisplay : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] TextMeshProUGUI statsText;

    void Start()
    {
        CalculateAndShowStats();
    }

    void CalculateAndShowStats()
    {
        int enemyStat = WaveManager.GetMonsterStat();
        int currentWave = WaveManager.currentWave;
        int currentSurvival = 0;
        foreach (string member in CommunityManager.members)
        {
            if (CommunityManager.npcStats.ContainsKey(member))
            {
                currentSurvival += CommunityManager.npcStats[member].survival;
            }
        }
        float chance = 0f;
        int totalPower = currentSurvival + enemyStat;
        
        if (totalPower > 0)
        {
            chance = (float)currentSurvival / totalPower * 100f;
        }

        if (statsText != null)
        {
            statsText.text = $"<b>Day {currentWave}</b>\n" +
                             $"Enemy Threat: <color=red>{enemyStat}</color>\n" +
                             $"Team Survival: <color=green>{currentSurvival}</color>\n" +
                             $"Base Chance: <color=yellow>{chance:0}%</color>";
        }
        else
        {
            Debug.LogWarning("TeamStatsDisplay: Belum ada Text yang dimasukkan di Inspector!");
        }
    }
}