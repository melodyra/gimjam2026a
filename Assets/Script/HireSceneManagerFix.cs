using UnityEngine;
using UnityEngine.SceneManagement;

public class HireSceneManagerFix : MonoBehaviour
{
    void Start()
    {
        CommunityManager.PrintCommunity("MASUK HIRE SCENE");
    }

    public void Hire()
    {
        string selectedNPC = HireController.selectedNPC;

        if (string.IsNullOrEmpty(selectedNPC))
        {
            Debug.Log("BELUM PILIH NPC!");
            return;
        }

        CommunityManager.hiredCandidate = selectedNPC;
        Debug.Log("NPC dipilih: " + selectedNPC);

        if (CommunityManager.npcStats.ContainsKey(selectedNPC))
        {
            var stat = CommunityManager.npcStats[selectedNPC];
            Debug.Log($"Stat NPC → Survival: {stat.survival}, Potential: {stat.potential}");
        }

        SceneManager.LoadScene("FireSceneFix");
    }
}
