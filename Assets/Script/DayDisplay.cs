using UnityEngine;
using TMPro; 

public class DayDisplay : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] TextMeshProUGUI dayText; 

    void Start()
    {
        int currentDay = WaveManager.currentWave; 
        if (dayText != null)
        {
            dayText.text = "Day " + currentDay;
        }
        else
        {
            Debug.LogWarning("DayDisplay: Text Component belum dimasukkan di Inspector!");
        }
    }
}