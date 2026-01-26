using System.Collections.Generic;
using UnityEngine;

public class FireRandomPosition : MonoBehaviour
{
    [Header("Semua Tombol NPC (9)")]
    public List<GameObject> npcButtons;

    List<Vector2> slots = new List<Vector2>()
    {
        new Vector2(-632,  333),
        new Vector2(-632,    0),
        new Vector2(-632, -315),

        new Vector2(0,     333),
        new Vector2(0,       0),
        new Vector2(0,    -315),

        new Vector2(638,   333),
        new Vector2(638,     0),
        new Vector2(638,  -315),
    };

    void Start()
    {
        RandomizePositions();
    }

    void RandomizePositions()
    {
        // copy list
        List<GameObject> shuffled = new List<GameObject>(npcButtons);

        // Fisher–Yates shuffle
        for (int i = 0; i < shuffled.Count; i++)
        {
            int rand = Random.Range(i, shuffled.Count);
            (shuffled[i], shuffled[rand]) = (shuffled[rand], shuffled[i]);
        }

        // pasang ke slot
        for (int i = 0; i < shuffled.Count && i < slots.Count; i++)
        {
            RectTransform rt = shuffled[i].GetComponent<RectTransform>();
            rt.anchoredPosition = slots[i];
        }
    }
}
