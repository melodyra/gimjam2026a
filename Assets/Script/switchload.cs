using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swtichload : MonoBehaviour
{
    [SerializeField] GameObject input;
    [SerializeField] GameObject output;
    public void loading()
    {
        input.SetActive(false);
        output.SetActive(true);
    }
}
