using System.Collections.Generic;
using UnityEngine;

public class FireRandomPosition : MonoBehaviour
{
    [Header("Semua Tombol Anggota")]
    public List<GameObject> npcButtons;

    List<Vector2> slots = new List<Vector2>()
    {
        new Vector2(-528, 334), new Vector2(-0, 334), new Vector2(528, 334),
        new Vector2(-528, 112), new Vector2(0, 112), new Vector2(528, 112),
        new Vector2(-528, -109), new Vector2(0, -109), new Vector2(528, -109),
        new Vector2(0,-322)
    };

    void Start()
    {
        RandomizePositions();
    }
    
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