using System.Collections.Generic;
using UnityEngine;

public class FireRandomPosition : MonoBehaviour
{
    [Header("Semua Tombol Anggota (Total 18 atau semua kemungkinan NPC)")]
    public List<GameObject> npcButtons;

    List<Vector2> slots = new List<Vector2>()
    {
        new Vector2(-632,  333), new Vector2(-632,    0), new Vector2(-632, -315),
        new Vector2(0,     333), new Vector2(0,       0), new Vector2(0,    -315),
        new Vector2(638,   333), new Vector2(638,     0), new Vector2(638,  -315),
    };

    void OnEnable()
    {
        RandomizePositions();
    }

    void RandomizePositions()
    {
        foreach (var btn in npcButtons)
        {
            btn.SetActive(false);
        }
        List<GameObject> activeMembersButtons = new List<GameObject>();
        foreach (var btn in npcButtons)
        {
            if (CommunityManager.members.Contains(btn.name))
            {
                activeMembersButtons.Add(btn);
            }
        }
        for (int i = 0; i < activeMembersButtons.Count; i++)
        {
            int rand = Random.Range(i, activeMembersButtons.Count);
            (activeMembersButtons[i], activeMembersButtons[rand]) = (activeMembersButtons[rand], activeMembersButtons[i]);
        }
        for (int i = 0; i < activeMembersButtons.Count && i < slots.Count; i++)
        {
            activeMembersButtons[i].SetActive(true); // Aktifkan panelnya
            RectTransform rt = activeMembersButtons[i].GetComponent<RectTransform>();
            rt.anchoredPosition = slots[i];
        }
    }
}