using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    public float rotateSpeed;

    //private Vector2 movementValue;

    //private float lookValue;

    // Start is called before the first frame update
    void Start()
    {
        //For locking the cursor in place at the start
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //Moves forward along the z axis (forward)
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //Moves forward along the x axis
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //Moves forward along the x axis
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //Moves forward along the x axis
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX*rotateSpeed*Time.deltaTime, 0);

    }
}
