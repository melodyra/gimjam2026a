using System.Collections.Generic;
using UnityEngine;

public static class CommunityManager
{
    // MEMBER DEFAULT 
    private static readonly List<string> defaultMembers = new List<string>()
    {
        "aquairo",
        "mlmenang",
        "mlkalah",
        "masjidroblox",
        "gimjamyt",
        "robloxkembar",
        "robloxmvp",
        "robloxgunung",
        "robloxdaging"
    };

    public static List<string> members = new List<string>();
    public static string hiredCandidate = "";

    // DATABASE STAT NPC
    public static Dictionary<string, NPCStat> npcStats = new Dictionary<string, NPCStat>()
    {
        // NPC AWAL
        { "aquairo", new NPCStat(0, 50) },
        { "mlmenang", new NPCStat(65, 20) },
        { "mlkalah", new NPCStat(50, 50) },
        { "masjidroblox", new NPCStat(15, 85) },
        { "gimjamyt", new NPCStat(70, 55) },
        { "robloxkembar", new NPCStat(35, 75) },
        { "robloxmvp", new NPCStat(67, 45) },
        { "robloxgunung", new NPCStat(80, 55) },
        { "robloxdaging", new NPCStat(52, 77) },
        
        // NPC HIRE (Potensial, Survival )
        { "miku", new NPCStat(57, 90) },
        { "alalten", new NPCStat(62, 20) },
        { "sicbg3", new NPCStat(85, 55) },
        { "NPC14", new NPCStat(87, 15) },
        { "NPC15", new NPCStat(65, 65) },
        { "NPC16", new NPCStat(79, 10) },
        { "NPC17", new NPCStat(30, 64) },
        { "NPC18", new NPCStat(73, 66) },
        { "NPC19", new NPCStat(27, 27) }
    };

    // RESET WAJIB (INI KUNCI)
    public static void ResetCommunity()
    {
        members = new List<string>(defaultMembers);
        hiredCandidate = "";
        Debug.Log("Members: " + string.Join(", ", members));
    }

    // TOTAL STAT
    public static void GetCommunityStats(out int totalSurvival, out int totalPotential)
    {
        totalSurvival = 0;
        totalPotential = 0;

        foreach (var member in members)
        {
            if (npcStats.ContainsKey(member))
            {
                totalSurvival += npcStats[member].survival;
                totalPotential += npcStats[member].potential;
            }
        }
    }

    public static void PrintCommunity(string title)
    {
        GetCommunityStats(out int surv, out int pot);
        Debug.Log("Members: " + string.Join(", ", members));
        Debug.Log($"Total Survival: {surv}");
        Debug.Log($"Total Potential: {pot}");
    }

    public class NPCStat
    {
        public int potential;
        public int survival;

        public NPCStat(int pot, int surv)
        {
            potential = pot;
            survival = surv;
        }
    }
}