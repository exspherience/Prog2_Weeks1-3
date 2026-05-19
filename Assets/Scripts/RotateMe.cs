using UnityEngine;

public class RotateMe : MonoBehaviour
{
    // speed will change rotate by degrees
    // 100 is good speed, 1 will be very slow
    public float speed = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotation happens on Z axis in 2D
        // do not rotate Y or X
        // Positive rotates counter clockwise
        // Negative rotates clockwise

        // do NOT use transform.rotation! rotation is a Quaternion
        // TO CORRECTLY ROTATE 
        // transform.eulerAngles

        // like transform.position, cannot assign value direction
        // must use Vector
        // cannot use Vector2 since we want to change Z component
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;

    }
}
