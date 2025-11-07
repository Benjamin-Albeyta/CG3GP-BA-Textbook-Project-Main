using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiesUI : MonoBehaviour
{

    TMP_Text text;

/*
    void Awake()
    {
        text = GetComponent<TMP_Text>();
        EnemyManager.instance.onChanged.AddListener(RefreshText);
    } */

    void Start()
    {
        text = GetComponent<TMP_Text>();
        EnemyManager.instance.onChanged.AddListener(RefreshText);
    }

    // Update is called once per frame
    void RefreshText()
    {
        text.text = "Remaining Enemies: " + EnemyManager.instance.enemies.Count;
    }
}
