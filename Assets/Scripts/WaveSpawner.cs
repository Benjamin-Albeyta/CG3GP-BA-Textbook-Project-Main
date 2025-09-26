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
        WavesManager.instance.AddWave(this);
        InvokeRepeating("Spawn", Start_time, Spawn_rate);
        Invoke("EndSpawner", End_time);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        WavesManager.instance.waves.Remove(this);
        CancelInvoke();
    }

}
