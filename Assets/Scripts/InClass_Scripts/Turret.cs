using UnityEngine;
using UnityEngine.InputSystem;

// Script to make object point towards another object
public class Turret : MonoBehaviour
{
    public Transform target; // set target in Inspector!
    public bool leftMousePressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Only update when mouse clicked:
        leftMousePressed = Mouse.current.leftButton.wasPressedThisFrame;

        if (leftMousePressed)
        {
            // Direction to B from A: B - A
            // Direction from this object towards target
            Vector3 directionToTarget = target.position - transform.position;
            transform.up = directionToTarget;
        }
    }
}
