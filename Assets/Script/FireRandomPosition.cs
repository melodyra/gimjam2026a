using System.Collections.Generic;
using UnityEngine;

public class FireRandomPosition : MonoBehaviour
{
    [Header("Semua Tombol Anggota")]
    public List<GameObject> npcButtons;

    List<Vector2> slots = new List<Vector2>()
    {
        new Vector2(-632,  333), new Vector2(-632,    0), new Vector2(-632, -315),
        new Vector2(0,     333), new Vector2(0,       0), new Vector2(0,    -315),
        new Vector2(638,   333), new Vector2(638,     0), new Vector2(638,  -315),
    };

    // Gunakan Start agar hanya jalan 1x saat Scene loading
    void Start()
    {
        RandomizePositions();
    }

    // OnEnable dikosongkan atau dihapus saja
    
    public void RandomizePositions()
    {
        foreach (var btn in npcButtons)
        {
            if (btn != null) btn.SetActive(false);
        }

        List<GameObject> activeMembersButtons = new List<GameObject>();
        foreach (var btn in npcButtons)
        {
            if (btn != null && CommunityManager.members.Contains(btn.name))
            {
                activeMembersButtons.Add(btn);
            }
        }

        for (int i = 0; i < activeMembersButtons.Count; i++)
        {
            int rand = Random.Range(i, activeMembersButtons.Count);
            GameObject temp = activeMembersButtons[i];
            activeMembersButtons[i] = activeMembersButtons[rand];
            activeMembersButtons[rand] = temp;
        }

        for (int i = 0; i < activeMembersButtons.Count && i < slots.Count; i++)
        {
            activeMembersButtons[i].SetActive(true); 
            RectTransform rt = activeMembersButtons[i].GetComponent<RectTransform>();
            if (rt != null)
            {
                rt.anchoredPosition = slots[i];
            }
        }
    }
}