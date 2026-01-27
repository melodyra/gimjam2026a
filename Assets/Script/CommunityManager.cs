using System.Collections.Generic;
using UnityEngine;

public static class CommunityManager
{
    public static readonly List<string> allHireableNPCs = new List<string>()
    {
        "miku", "alalten", "sicbg3", "NPC14", "NPC15", "NPC16", "NPC17", "NPC18", "NPC19"
    };

    public static List<string> members = new List<string>();
    public static string hiredCandidate = "";
    public static HashSet<string> potentialUsed = new HashSet<string>();
    public static HashSet<string> firedNPCs = new HashSet<string>();

    public static Dictionary<string, NPCStat> npcStats = new Dictionary<string, NPCStat>()
    {
        { "NPC1", new NPCStat(0, 50) }, { "NPC2", new NPCStat(65, 20) }, { "NPC3", new NPCStat(50, 50) },
        { "NPC4", new NPCStat(15, 85) }, { "NPC5", new NPCStat(70, 55) }, { "NPC6", new NPCStat(35, 75) },
        { "NPC7", new NPCStat(67, 45) }, { "NPC8", new NPCStat(80, 55) }, { "NPC9", new NPCStat(52, 77) },
        { "NPC10", new NPCStat(75, 75) }, 
        
        { "miku", new NPCStat(57, 90) }, { "alalten", new NPCStat(62, 20) }, { "sicbg3", new NPCStat(85, 55) },
        { "NPC14", new NPCStat(87, 15) }, { "NPC15", new NPCStat(65, 65) }, { "NPC16", new NPCStat(79, 10) },
        { "NPC17", new NPCStat(30, 64) }, { "NPC18", new NPCStat(73, 66) }, { "NPC19", new NPCStat(27, 27) }
    };

    public static void ResetCommunity()
    {
        members = new List<string>() { "NPC1", "NPC2", "NPC3", "NPC4", "NPC5", "NPC6", "NPC7", "NPC8", "NPC9", "NPC10" };
        hiredCandidate = "";
        potentialUsed.Clear();
        firedNPCs.Clear();
    }

    public static void GetCommunityStats(out int totalSurvival)
    {
        totalSurvival = 0;
        foreach (var member in members)
        {
            if (npcStats.ContainsKey(member)) 
            {
                int currentSurvival = npcStats[member].survival;
                if (!potentialUsed.Contains(member))
                {
                    int roll = Random.Range(1, 101);
                    if (roll <= npcStats[member].potential)
                    {
                        currentSurvival *= 2;
                        Debug.Log($"{member} TRIGGER POTENSI! Survival jadi: {currentSurvival}");
                    }
                    potentialUsed.Add(member);
                }
                totalSurvival += currentSurvival;
            }
        }
    }

    public static void PrintCommunity(string title) {
        Debug.Log($"--- {title} ---");
        Debug.Log("Anggota saat ini: " + string.Join(", ", members));
    }

    public class NPCStat {
        public int potential; public int survival;
        public NPCStat(int pot, int surv) { potential = pot; survival = surv; }
    }
}