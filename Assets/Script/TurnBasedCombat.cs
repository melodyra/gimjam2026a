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

    [Header("Battle Stats")]
    [SerializeField] int monsterStat = 300;
    [SerializeField] float potentialMultiplier = 0.1f;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshProUGUI enemyHealthText;
    [SerializeField] TextMeshProUGUI chanceText;
    [SerializeField] Button attackButton;

    int cachedChancePercent;

    void Start()
    {
        CalculateAndShowChance();
        attackButton.onClick.AddListener(ResolveBattle);
    }

    void CalculateAndShowChance()
    {
        CommunityManager.GetCommunityStats(
            out int totalSurvival,
            out int totalPotential
        );

        int communityPower =
            totalSurvival +
            Mathf.RoundToInt(totalPotential * potentialMultiplier);

        float chance =
            (float)communityPower /
            (communityPower + monsterStat);

        cachedChancePercent = Mathf.RoundToInt(chance * 100f);

        playerHealthText.text = "Community";
        enemyHealthText.text = monsterStat.ToString();
        chanceText.text = $"Chance to Survive: {cachedChancePercent}%";

        Debug.Log($"Survival: {totalSurvival}");
        Debug.Log($"Potential: {totalPotential}");
        Debug.Log($"Power: {communityPower}");
        Debug.Log($"Chance: {cachedChancePercent}%");
    }

    void ResolveBattle()
    {
        attackButton.interactable = false;

        int roll = Random.Range(0, 101);
        Debug.Log($"ROLL: {roll}");

        StartCoroutine(DoAttack(player, enemy, () =>
        {
            if (roll <= cachedChancePercent)
            {
                Debug.Log("MENANG");
                enemyHealthText.text = "DEFEATED";
                playerHealthText.text = "SURVIVED";
            }
            else
            {
                Debug.Log("KALAH");
                enemyHealthText.text = "SURVIVED";
                playerHealthText.text = "DESTROYED";
                Invoke(nameof(LoadLoseScene), 1.2f);
            }
        }));
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
