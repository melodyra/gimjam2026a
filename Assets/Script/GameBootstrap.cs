using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBootstrap : MonoBehaviour
{
    void Awake()
    {
        CommunityManager.ResetCommunity();
    }
    public void LoadHireScene()
    {
        SceneManager.LoadScene("HireSceneFix"); 
    }
}
