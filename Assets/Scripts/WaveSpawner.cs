using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public GameObject prefab;

    public float Start_time;

    public float End_time;

    public float Spawn_rate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", Start_time, Spawn_rate);
        Invoke("CancelInvoke", End_time);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
