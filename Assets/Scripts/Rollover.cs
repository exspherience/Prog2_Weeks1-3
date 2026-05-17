using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public float distanceThreshold = 1f;
    public float duration;

    public AnimationCurve vibrateCurve;
    bool timerRun = false;
    float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // if mouse is close to object
        if (Vector2.Distance(transform.position, mousePosition) < distanceThreshold)
        {
            timerRun = true;
        }
        else
        {
            timerRun = false;
        }

        if (timerRun)
        {
            timer += Time.deltaTime;
            transform.localScale = vibrateCurve.Evaluate(timer) * Vector3.one;
        }
        else
        {
            timer = 0;
        }
    }
}
