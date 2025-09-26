using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int amount;

    void GivePoints()
    {
        ScoreManager.instance.amount += amount;
    }

    private void Awake()
    {
        var life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }

}
