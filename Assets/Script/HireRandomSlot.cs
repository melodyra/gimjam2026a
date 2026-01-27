using System.Collections.Generic;
using UnityEngine;

public class HireRandomSlot : MonoBehaviour
{
    [Header("Semua Tombol NPC (9)")]
    public List<GameObject> npcButtons;

    [Header("Slot Posisi")]
    public Vector2 slot1 = new Vector2(-580, 333);
    public Vector2 slot2 = new Vector2(-580, 18);
    public Vector2 slot3 = new Vector2(-580, -315);

    void OnEnable()
    {
        RandomizeNPCButtons();
    }

    public void RandomizeNPCButtons()
    {
        foreach (var btn in npcButtons)
            btn.SetActive(false);
        List<GameObject> shuffled = new List<GameObject>(npcButtons);
        for (int i = 0; i < shuffled.Count; i++)
        {
            int rand = Random.Range(i, shuffled.Count);
            (shuffled[i], shuffled[rand]) = (shuffled[rand], shuffled[i]);
        }
        SetButton(shuffled[0], slot1);
        SetButton(shuffled[1], slot2);
        SetButton(shuffled[2], slot3);
    }

    void SetButton(GameObject btn, Vector2 pos)
    {
        btn.SetActive(true);
        RectTransform rt = btn.GetComponent<RectTransform>();
        rt.anchoredPosition = pos;
    }
}