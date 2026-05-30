using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;

    // Min and Max X & Y locations
    // Set on object
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;

    public float progress = 0;
    public float duration = 3f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; // Set Start to Object position
        selectEndPosition();
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        // Lerp to move object
        transform.position = Vector2.Lerp(startPos, endPos, progress/duration);

        // Call function to update position start and end
        changeLocation();
    }
    void changeLocation()
    {
        if (progress/duration >= 1)
        {
            // change start position, select new end position
            startPos = endPos;
            selectEndPosition();

            // reset progress to keep objects moving
            progress = 0;
        }
    }

    // Set End Position to random location in Range
    void selectEndPosition()
    {
        endPos.x = Random.Range(xMin, xMax);
        endPos.y = Random.Range(yMin, yMax);
    }
}
