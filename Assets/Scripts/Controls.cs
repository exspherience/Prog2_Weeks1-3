using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    public bool leftMousePressed = false;
    public bool rightMousePressed = false;
    public bool anyKeyPressed = false;
    public float speed = 3;
    public float rotationSpeed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check if mouse buttons pressed
        // isPressed true all time button presssed
        // example use: firing gun while button held
        leftMousePressed = Mouse.current.leftButton.isPressed;
        rightMousePressed = Mouse.current.rightButton.isPressed;
    
        //wasPressedThisFrame is true the first frame button pressed only
        //wasReleasedThisFrame is true the first frame button released only
        // example use: firing gun a single time for button press, ignoring hold
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Left Button Pressed");
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Debug.Log("Right Button Pressed");
        }

        anyKeyPressed = Keyboard.current.anyKey.isPressed;

        Vector2 newPos = transform.position;
        Vector3 newRotation = transform.eulerAngles;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            // move to the left
            //newPos.x -= speed * Time.deltaTime;
            //transform.position = newPos;

            // rotate to the left
            newRotation.z += rotationSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        if(Keyboard.current.rightArrowKey.isPressed)
        {
            // move right
            //newPos.x += speed * Time.deltaTime;
            //transform.position = newPos;

            // rotate right
            newRotation.z -= rotationSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            // move up on y axis
            //newPos.y += speed * Time.deltaTime;
            //transform.position = newPos;

            // move forward based on direction sprite faces
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if(Keyboard.current.downArrowKey.isPressed)
        {
            //newPos.y -= speed * Time.deltaTime;
            //transform.position = newPos;

            // move back based on direction sprite faces
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}
