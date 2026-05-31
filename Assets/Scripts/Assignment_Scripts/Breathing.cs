using UnityEngine;

public class Breathing : MonoBehaviour
{
    // desired start and end sizes
    public Vector3 startSize;
    public Vector3 endSize;

    // variables for animation
    public float duration;
    public float progress = 0f;

    // direction starts positive (growing)
    public float direction = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // create timer
        progress += Time.deltaTime * direction;

        // if progress exceeds 1, change direction to negative this will make size decrease
        // if progress goes below 0, multiply by negative to put direction back to positive (growing)
        if (progress > 1 || progress < 0)
        {
            direction *= -1;
        }

        // change the local scale with a Lerp
        transform.localScale = Vector2.Lerp(startSize, endSize, progress / duration);
    }
}
