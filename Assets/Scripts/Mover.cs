using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;
    public float progress = 0;
    public float duration = 3f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; // Set Start to Objecct position
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
        /*  Update the starting position to be its current position
         *  Pick a new random position for the destination
         *  Reset t variable for your timer so the shape keeps moving */
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
    // TODO: Update Range once visuals are added
    void selectEndPosition()
    {
        endPos.x = Random.Range(-7, -3);
        endPos.y = Random.Range(-3, 0);
    }
}
