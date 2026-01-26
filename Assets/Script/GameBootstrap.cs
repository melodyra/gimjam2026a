using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBootstrap : MonoBehaviour
{
    void Awake()
    {
        CommunityManager.ResetCommunity();
        WaveManager.ResetWave();

        Debug.Log("GAME START - WAVE 1");
    }
    public void LoadHireScene()
    {
        SceneManager.LoadScene("HireSceneFix"); 
    }
}
