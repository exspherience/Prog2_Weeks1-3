using UnityEngine;
using UnityEngine.InputSystem;

public class PointMe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // find direction between position and mouse position
        // best option when working with only x & y is to cast transform.position into Vector2
        // target position - transform.position
        Vector2 direction = mousePos - (Vector2)transform.position;
        // set transform.up direction to equal that
        transform.up = direction;
    }
}
