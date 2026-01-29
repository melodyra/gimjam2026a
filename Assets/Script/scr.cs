using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour
{
    public SpriteRenderer sprite;
    Color c;
    void Start()
    {
        c = sprite.color;
        c.a = 0;
        sprite.color = c;
        StartCoroutine(FadeCoroutine(5f));
    }

    IEnumerator FadeCoroutine(float duration)
    {
        float t = 0f;

        while (t < duration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Lerp(0f, 1f, t / duration);
            sprite.color = c;
            yield return null; 
        }

        c.a = 255;
        sprite.color = c;
        while (t < 3)
        {
            t += Time.deltaTime;
            yield return null; 
        }
        gameObject.SetActive(false); 
        SceneManager.LoadScene(2);
    }
}
