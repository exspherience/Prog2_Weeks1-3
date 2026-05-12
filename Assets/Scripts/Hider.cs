using UnityEngine;
using UnityEngine.InputSystem;

public class Hider : MonoBehaviour
{
    public Vector2 hidePosition;
    public Vector2 showPosition;
    public float hideDistanceThreshold = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // if mouse is close to object
        if (Vector2.Distance(transform.position, mousePosition) < hideDistanceThreshold)
        {
            transform.position = hidePosition;
        }
    }
}