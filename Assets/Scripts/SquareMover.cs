using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float speed = 0.01f;
    public float xMax = 10f;
    public float xMin = -10f;
    public float topSpeed = 0.3f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position.x += 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        
        if (newPosition.x >= xMax || newPosition.x <= xMin)
        {
            speed *= -1f;
        }

        newPosition.x += speed;
        transform.position = newPosition;
    }
}
