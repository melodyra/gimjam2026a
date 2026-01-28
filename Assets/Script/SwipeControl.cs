using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeControl    : MonoBehaviour {
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[] pos;

    void Update () {
        List<Transform> activeNPCs = new List<Transform>();
        foreach (Transform child in transform) {
            if (child.gameObject.activeSelf) activeNPCs.Add(child);
        }

        int count = activeNPCs.Count;
        if (count == 0) return;

        pos = new float[count];
        float distance = 1f / (count > 1 ? count - 1 : 1);
        
        for (int i = 0; i < pos.Length; i++) {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0)) {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        } else {
            for (int i = 0; i < pos.Length; i++) {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2)) {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.15f);
                }
            }
        }
    }
}