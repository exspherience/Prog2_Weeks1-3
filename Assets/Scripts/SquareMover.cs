using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float speed = 1f;
    public float xMax = 10f;
    public float xMin = -10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position.x += 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        // deltaTime moves options per second instead of per frame
        // want to use when moving an object over time (changing speed or position over time)
        // if instantaneous change, Do Not used deltaTime
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;

        if (newPosition.x >= xMax || newPosition.x <= xMin)
        {
            speed *= -1f;
        }

    }
}
