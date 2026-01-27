using UnityEngine;
using UnityEngine.SceneManagement;

public class FireSceneManagerFix : MonoBehaviour
{
    bool alreadyFired = false;

    void Start()
    {
        CommunityManager.PrintCommunity("MEMBER AWAL");
    }

    public void Fire()
    {
        if (alreadyFired) return;
        alreadyFired = true;

        string firedNPC = FireController.selectedNPC;

        if (string.IsNullOrEmpty(firedNPC))
        {
            Debug.LogError("BELUM PILIH NPC UNTUK DI-FIRE");
            alreadyFired = false; 
            return;
        }

        if (!CommunityManager.members.Contains(firedNPC))
        {
            Debug.LogError("NPC TIDAK ADA DI MEMBER: " + firedNPC);
            alreadyFired = false;
            return;
        }

        CommunityManager.members.Remove(firedNPC);
        CommunityManager.firedNPCs.Add(firedNPC);

        if (!string.IsNullOrEmpty(CommunityManager.hiredCandidate))
        {
            string newNPC = CommunityManager.hiredCandidate;
            if (!CommunityManager.members.Contains(newNPC))
                CommunityManager.members.Add(newNPC);
        }

        CommunityManager.hiredCandidate = "";
        SceneManager.LoadScene("GamePlay");
    }
}