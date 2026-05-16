using UnityEngine;

public class Searching : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;
    public float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        endPos.x = Random.Range(-5, 5);
        endPos.y = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        
        // In Update use Lerp to move from the starting position to the destination
        transform.position = Vector2.Lerp(startPos, endPos, t);
        changeLocation();
    }
    void changeLocation()
    {
        /*  Update the starting position to be its current position
         *  Pick a new random position for the destination
         *  Reset the t variable for your timer so the shape keeps moving */
        if (t >= 1)
        {
            startPos = endPos;
            endPos.x = Random.Range(-5, 5);
            endPos.y = Random.Range(-5, 5);
            t = 0;
        }
    }
}
