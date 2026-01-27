using System.Collections.Generic;
using UnityEngine;

public class HireRandomSlot : MonoBehaviour
{
    [Header("Semua Tombol NPC")]
    public List<GameObject> npcButtons;

    [Header("Slot Posisi")]
    public Vector2 slot1 = new Vector2(-580, 333);
    public Vector2 slot2 = new Vector2(-580, 0);
    public Vector2 slot3 = new Vector2(-580, -333);

    void Start()
    {
        RandomizeNPCButtons();
    }

    public void RandomizeNPCButtons()
    {
        foreach (var btn in npcButtons)
        {
            if (btn != null) btn.SetActive(false);
        }

        List<GameObject> availableButtons = new List<GameObject>();
        foreach (var btn in npcButtons)
        {
            if (btn != null)
            {
                bool isMember = CommunityManager.members.Contains(btn.name);
                bool wasFired = CommunityManager.firedNPCs.Contains(btn.name);

                if (!isMember && !wasFired)
                {
                    availableButtons.Add(btn);
                }
            }
        }

        for (int i = 0; i < availableButtons.Count; i++)
        {
            int rand = Random.Range(i, availableButtons.Count);
            GameObject temp = availableButtons[i];
            availableButtons[i] = availableButtons[rand];
            availableButtons[rand] = temp;
        }

        if (availableButtons.Count >= 1) SetButton(availableButtons[0], slot1);
        if (availableButtons.Count >= 2) SetButton(availableButtons[1], slot2);
        if (availableButtons.Count >= 3) SetButton(availableButtons[2], slot3);
    }

    void SetButton(GameObject btn, Vector2 pos)
    {
        btn.SetActive(true);
        RectTransform rt = btn.GetComponent<RectTransform>();
        if (rt != null)
        {
            rt.anchoredPosition = pos;
        }
    }
}