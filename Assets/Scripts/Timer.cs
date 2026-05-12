using UnityEngine;

public class Timer : MonoBehaviour
{
    public float duration = 10;
    float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        if(progress >= duration)
        {
            Debug.Log("Time is Up");
        }
    }
}
