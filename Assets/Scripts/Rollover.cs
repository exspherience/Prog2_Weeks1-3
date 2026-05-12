using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    // bool is the variable type we want
    // "Boolean" is not the same and not as useful
    // Using camelCase will add spaces to the inspector name when variable is public
    // booleans are depicted as a check box in the Unity Inspector
    // the Inspector can be used to debug variables if variables are public
    public bool mouseOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position (in pixels), convert to world space (in meters)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // get distance between transform.position & mouse position
        float distance = Vector2.Distance(transform.position, mousePos);
        // if distance is small (<1), mouseOver set to true
        if(distance < 1)
        {
            mouseOver = true;
        }
        else
        {
            mouseOver = false;
        }
    }
}
