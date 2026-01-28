using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveManager : MonoBehaviour
{
    public static int currentWave = 1;

    static readonly int[] monsterStats = { 950, 1100, 1250, 1400, 1650, 1800 };

    void Awake()
    {
        if (FindObjectsOfType<WaveManager>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public static int GetMonsterStat()
    {
        return monsterStats[currentWave - 1];
    }
    public static string GetNextSceneName()
    {
        if (currentWave == 3)
        {
            return "CutScene2";
        }
        return "HireSceneFix";
    }

    public static void NextWave()
    {
        currentWave++;
        Debug.Log("MASUK WAVE SEKARANG: " + currentWave);
    }

    public static bool IsLastWave()
    {
        return currentWave >= monsterStats.Length;
    }

    public static void ResetWave()
    {
        currentWave = 1;
        Debug.Log("WAVE RESET");
    }
}