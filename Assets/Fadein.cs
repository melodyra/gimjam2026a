using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadein : MonoBehaviour
{
    public GameObject signal;
    public
    void Update()
    {
        if (!signal.activeInHierarchy)
        {
            StartCoroutine(FadeIn(5f));
        }
    }
    IEnumerator Fade(float duration)
    {
        float t = 0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Lerp(0f, 1f, t / duration);
            yield return null;
        }
    }
}
