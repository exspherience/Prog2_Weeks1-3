using UnityEngine;

public class Guard : MonoBehaviour
{
    public Vector3  startValue;
    public Vector3 endValue;

    public Vector3 currentValue;

    public float duration;

    float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        // progress value in Lerp should be between 0 and 1
        // when progress 0, Lerp gives Start Value | when 1, Lerp gives endValue

        // below is for numbers
        // currentValue = Mathf.Lerp(startValue, endValue, progress/duration);

        // vectors (ex. positions)
        currentValue = Vector3.Lerp(startValue, endValue, progress / duration);

        transform.position = currentValue;

        if(progress >= duration)
        {
            progress = 0f;
        }
    }
}
