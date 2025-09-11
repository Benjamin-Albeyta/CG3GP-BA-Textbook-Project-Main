using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        print("test Start");
    }

    // Update is called once per frame
    void Update()
    {
        print(speed);

    }
}
