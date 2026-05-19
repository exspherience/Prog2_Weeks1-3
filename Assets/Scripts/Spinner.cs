using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 30f;
    public float zMax = 120f;
    public float zMin = -120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // euler angles for rotation
        // transform.rotation is quaterion
        Vector3 currentRotation = transform.eulerAngles;

        // transform shows values from -180 to 180
        // but eular angles goes from 0 to 360!
        // do not trust the inspector!!
        if(transform.eulerAngles.z > zMax || transform.eulerAngles.z < zMin)
        {
            Debug.Log("CurrentZ: " + currentRotation.z.ToString() + "Max Z: " + zMax.ToString());
            speed = -speed;
        }
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;
    }
}
