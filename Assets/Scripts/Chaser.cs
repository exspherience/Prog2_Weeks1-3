using UnityEngine;
using UnityEngine.InputSystem;

public class Chaser : MonoBehaviour
{
    public Camera gameCamera; // create camera variable

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = mousePos;

        //Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        // because currentMousePosition will be real world values, chaser will be off screen
        // create a world mouse position to set mouse within window
        //Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        // set worldMousePosition to Z or else it will be at the camera Z location
        //worldMousePosition.z = 0f;
        //transform.position = worldMousePosition; // move circle to mouse position

    }
}
