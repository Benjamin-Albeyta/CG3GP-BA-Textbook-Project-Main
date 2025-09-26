using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static EnemyManager instance;

    public List<Enemy> enemies = new List<Enemy>();

    public UnityEvent onChanged = new UnityEvent();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
        onChanged.Invoke();
    }

    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        onChanged.Invoke();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
