using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public float speed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
            //newRotation.z -= rotationSpeed * Time.deltaTime;
            //transform.eulerAngles = newRotation;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}
