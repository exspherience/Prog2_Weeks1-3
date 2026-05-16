using System.Security.Cryptography;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float speed;
    public float duration = 1f;
    public float defaultX = 3;
    public AnimationCurve floatingCurve;
    float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // increase timer
        timer += speed;
        
        // move sprite with animation curve
        Vector2 newPos = transform.position;
        newPos = floatingCurve.Evaluate(timer / duration) * Vector3.one;
        newPos.x = defaultX; // keep x at the set position
        transform.position = newPos;
        //Debug.Log(timer);

        // reset timer
        if (timer >= duration)
        {
            timer = 0f;
        }
    }
}