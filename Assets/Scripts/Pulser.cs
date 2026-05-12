using UnityEngine;

public class Pulser : MonoBehaviour
{
    public AnimationCurve curve;
    public float startSize;
    public float endSize;

    public float duration;
    private float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        // localScale is vector3
        // changing it will change size of object
        transform.localScale = curve.Evaluate(progress/duration) * Vector3.one;
    }
}
