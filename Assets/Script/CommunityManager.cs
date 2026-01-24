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
        { "aquairo",       new NPCStat(20, 40) },
        { "mlmenang",      new NPCStat(25, 35) },
        { "mlkalah",       new NPCStat(15, 45) },
        { "masjidroblox",  new NPCStat(10, 50) },
        { "gimjamyt",      new NPCStat(30, 30) },
        { "robloxkembar",  new NPCStat(20, 40) },
        { "robloxmvp",     new NPCStat(35, 25) },
        { "robloxgunung",  new NPCStat(15, 45) },
        { "robloxdaging",  new NPCStat(25, 35) },

        // NPC HIRE (Potensial, Survival )
        { "miku",          new NPCStat(80, 55) },
        { "alalten",       new NPCStat(20, 90) },
        { "sicbg3",        new NPCStat(95, 25) }
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