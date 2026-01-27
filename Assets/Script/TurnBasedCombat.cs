using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TurnBasedCombat : MonoBehaviour
{
    [Header("Visual Objects")]
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshProUGUI enemyHealthText;
    [SerializeField] TextMeshProUGUI chanceText;
    [SerializeField] TextMeshProUGUI waveText;
    [SerializeField] Button attackButton;

    int monsterStat;
    int cachedChancePercent;
    bool battleResolved = false;

    void Start()
    {
        SetupWave();
        attackButton.onClick.AddListener(ResolveBattle);
    }

    void SetupWave()
    {
        monsterStat = WaveManager.GetMonsterStat();

        waveText.text = $"WAVE {WaveManager.currentWave}";
        enemyHealthText.text = monsterStat.ToString();
        playerHealthText.text = "Community";

        CalculateAndShowChance();
    }

    void CalculateAndShowChance()
    {
        CommunityManager.GetCommunityStats(out int totalSurvival);

        float chance = (float)totalSurvival / (totalSurvival + monsterStat);

        cachedChancePercent = Mathf.RoundToInt(chance * 100f);
        cachedChancePercent = Mathf.Clamp(cachedChancePercent, 1, 99);

        chanceText.text = $"Chance to Survive: {cachedChancePercent}%";

        Debug.Log($"WAVE {WaveManager.currentWave}");
        Debug.Log($"Total Survival Akhir: {totalSurvival}");
        Debug.Log($"Monster Stat: {monsterStat}");
        Debug.Log($"Win Chance: {cachedChancePercent}%");
    }

    void ResolveBattle()
    {
        if (battleResolved) return;
        battleResolved = true;

        attackButton.interactable = false;

        int roll = Random.Range(1, 101);
        Debug.Log($"ROLL: {roll} vs CHANCE: {cachedChancePercent}");

        StartCoroutine(DoAttack(player, enemy, () =>
        {
            if (roll <= cachedChancePercent)
            {
                HandleWin();
            }
            else
            {
                HandleLose();
            }
        }));
    }

    void HandleWin()
    {
        enemyHealthText.text = "DEFEATED";
        playerHealthText.text = "SURVIVED";
        Invoke(nameof(ProceedAfterWin), 1.2f);
    }

    void HandleLose()
    {
        enemyHealthText.text = "SURVIVED";
        playerHealthText.text = "DESTROYED";
        Invoke(nameof(LoadLoseScene), 1.2f);
    }

    void ProceedAfterWin()
    {
        if (WaveManager.IsLastWave())
        {
            SceneManager.LoadScene("WinScene");
        }
        else
        {
            WaveManager.NextWave();
            SceneManager.LoadScene("HireSceneFix");
        }
    }

    void LoadLoseScene()
    {
        SceneManager.LoadScene("LoseScene");
    }

    IEnumerator DoAttack(GameObject attacker, GameObject target, System.Action onComplete)
    {
        Vector3 start = attacker.transform.position;
        Vector3 end = start + (target.transform.position - start).normalized * 0.5f;

        yield return MoveOverTime(attacker, start, end, 0.15f);
        yield return MoveOverTime(attacker, end, start, 0.15f);

        onComplete?.Invoke();
    }

    IEnumerator MoveOverTime(GameObject obj, Vector3 start, Vector3 end, float duration)
    {
        float t = 0f;
        while (t < duration)
        {
            obj.transform.position = Vector3.Lerp(start, end, t / duration);
            t += Time.deltaTime;
            yield return null;
        }
        obj.transform.position = end;
    }
}