using UnityEngine;
using UnityEngine.SceneManagement;

public class FireSceneManagerFix : MonoBehaviour
{
    bool alreadyFired = false;

    void Start()
    {
        CommunityManager.PrintCommunity("MEMBER AWAL");

        Debug.Log("NPC DIHIRE: " +
            (string.IsNullOrEmpty(CommunityManager.hiredCandidate)
            ? "TIDAK ADA"
            : CommunityManager.hiredCandidate));
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

        Debug.Log("NPC DIFIRE : " + firedNPC);
        CommunityManager.GetCommunityStats(out int beforeSurv);
        Debug.Log($"STAT AWAL → Total Survival: {beforeSurv}");

        if (!CommunityManager.members.Contains(firedNPC))
        {
            Debug.LogError("NPC TIDAK ADA DI MEMBER: " + firedNPC);
            alreadyFired = false;
            return;
        }

        CommunityManager.members.Remove(firedNPC);

        if (!string.IsNullOrEmpty(CommunityManager.hiredCandidate))
        {
            string newNPC = CommunityManager.hiredCandidate;
            Debug.Log("NPC MASUK (HIRE): " + newNPC);

            if (!CommunityManager.members.Contains(newNPC))
                CommunityManager.members.Add(newNPC);
        }
        else
        {
            Debug.Log("TIDAK ADA NPC BARU YANG DIHIRE");
        }

        CommunityManager.hiredCandidate = "";
        CommunityManager.GetCommunityStats(out int afterSurv);
        Debug.Log($"STAT AKHIR → Total Survival: {afterSurv}");
        CommunityManager.PrintCommunity("MEMBER SETELAH FIRE");
        SceneManager.LoadScene("GamePlay");
    }
}