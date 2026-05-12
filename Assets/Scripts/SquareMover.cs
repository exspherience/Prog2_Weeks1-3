using UnityEngine;

public class SquareMover : MonoBehaviour
{
    // First number set
    // Inspector number will replace this value
    // Anything in Start() will override this and the Inspector number
    // Finally, any changes in Update() will be prioritized
    public float speed = 0.01f;
    public float xMax = 10f;
    public float xMin = -10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position.x += 1f;
        // Random.Value selects number between 0 and 1
        // Random.Range allows for a specified range of numbers
        // Random.RandomRange is old and no longer used
        //speed = Random.Range(0.01f, 0.3f);


        // insideUnitCircle returns Vector2; insideUnitSphere will return Vector3
        // insideUnitCircle is within a Circle with size 1, and will return a value from -1, 1
        // To increase this, the amount needs to be multiplied

        // to add variation to set starting position, add random to position
        // cannot simply add because insideUnitCircle is Vector2 and transform is vector3
        // transform.position = transform.position + Random.insideUnitCircle * 2; 
        // solution is to cast, recommended to cast 3D vector to 2D when working in 2D
        transform.position = (Vector2)transform.position + Random.insideUnitCircle * 2;   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition;

        if (newPosition.x >= xMax || newPosition.x <= xMin)
        {
            speed *= -1f;
        }
    }
}
