using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{

    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        //Using the gameObject class is a way to point to the game object the script is placed into
        Destroy(gameObject, delay);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
