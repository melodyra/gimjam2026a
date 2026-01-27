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

    void OnEnable() // Menggunakan OnEnable agar refresh setiap kali masuk scene
    {
        RandomizePositions();
    }

    void RandomizePositions()
    {
        // 1. Sembunyikan semua tombol dulu
        foreach (var btn in npcButtons)
        {
            btn.SetActive(false);
        }

        // 2. Filter: Cari tombol yang namanya ada di list CommunityManager.members
        List<GameObject> activeMembersButtons = new List<GameObject>();
        foreach (var btn in npcButtons)
        {
            if (CommunityManager.members.Contains(btn.name))
            {
                activeMembersButtons.Add(btn);
            }
        }

        // 3. Acak posisi tombol yang aktif saja
        for (int i = 0; i < activeMembersButtons.Count; i++)
        {
            int rand = Random.Range(i, activeMembersButtons.Count);
            (activeMembersButtons[i], activeMembersButtons[rand]) = (activeMembersButtons[rand], activeMembersButtons[i]);
        }

        // 4. Aktifkan tombol dan pasang ke slot (Maksimal 9 sesuai jumlah slot)
        for (int i = 0; i < activeMembersButtons.Count && i < slots.Count; i++)
        {
            activeMembersButtons[i].SetActive(true); // Aktifkan panelnya
            RectTransform rt = activeMembersButtons[i].GetComponent<RectTransform>();
            rt.anchoredPosition = slots[i];
        }
    }
}