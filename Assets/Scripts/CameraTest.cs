using UnityEngine;
using UnityEngine.InputSystem;

public class CameraTest : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;       // PlayerUnit
    public Transform cameraTransform;  // Main Camera (child)

    private float xRotation = 0f;
    private Vector2 lookInput;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }

    void Update()
    {
        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        // Rotate player (yaw)
        playerBody.Rotate(Vector3.up * mouseX);

        // Rotate camera (pitch)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
