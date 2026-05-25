using UnityEngine;
using UnityEngine.InputSystem;

public class TailFlick : MonoBehaviour
{
    public AnimationCurve flickCurve;
    public float targetAngle;
    public float flickDistanceThreshold = 1f;

    public float duration;
    public float progress = 0f;

    public bool flickTail;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        flick();
    }

    // Check that Mouse is near tail
    void checkDistance()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
        // If near tail, rotate
        if(Vector2.Distance(transform.position, mousePos) < flickDistanceThreshold)
        {
            flickTail = true;
        }
    }
    void flick()
    {
        if (flickTail)
        {
            progress += Time.deltaTime;

            // evaluate the rotation of the tailAngle vector
            // multiple the Evaluated curve by the targetAngle so it will rotate to that Angle
            Vector3 tailAngle = (flickCurve.Evaluate(progress / duration) * targetAngle) * Vector3.one;

            // Set eulerAngles to 0 in x and y, and tailAngle.z in z
            // This allows for only the Z to rotate 
            transform.eulerAngles = new Vector3(0, 0, tailAngle.z);

            if (progress >= 2)
            {
                flickTail = false;
                progress = 0f;
            }
        }
    }

}
