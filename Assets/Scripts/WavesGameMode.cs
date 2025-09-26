using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{

    [SerializeField] private Life playerLife;
    [SerializeField] private Life playerBaseLife;

    void CheckWinCondition()
    {
        if (EnemyManager.instance.enemies.Count <= 0 &&
        WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }


    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("LoseScreen");
    }

    // Start is called before the first frame update
    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemyManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);
    }

}
