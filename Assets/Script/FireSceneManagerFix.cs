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
            Debug.LogError(" BELUM PILIH NPC UNTUK DI-FIRE");
            return;
        }

        Debug.Log("NPC DIFIRE : " + firedNPC);

        CommunityManager.GetCommunityStats(out int beforeSurv, out int beforePot);
        Debug.Log($"STAT AWAL → Survival: {beforeSurv}, Potential: {beforePot}");
        if (!CommunityManager.members.Contains(firedNPC))
        {
            Debug.LogError("NPC TIDAK ADA DI MEMBER: " + firedNPC);
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

        CommunityManager.GetCommunityStats(out int afterSurv, out int afterPot);
        Debug.Log($"STAT AKHIR → Survival: {afterSurv}, Potential: {afterPot}");

        CommunityManager.PrintCommunity("MEMBER SETELAH FIRE");
        SceneManager.LoadScene("GamePlay");
    }
}
