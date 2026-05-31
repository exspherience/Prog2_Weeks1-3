using UnityEngine;

public class Mover : MonoBehaviour
{
    // animation curve for easing
    public AnimationCurve movementCurve;

    // start and end position variables
    public Vector2 start;
    public Vector2 end;

    // variables for timer
    float progress;
    public float duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // start timer
        progress += Time.deltaTime;

        // change position with lerp, and ease with animation curve
        transform.position = Vector2.Lerp(start, end, movementCurve.Evaluate(progress / duration));

        // when x position of object matches x of set end position, restart timer
        // sets object back to start
        if(transform.position.x == end.x)
        {
            progress = 0f;
        }
    }
}
