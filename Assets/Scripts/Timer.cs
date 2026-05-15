using UnityEngine;

public class Timer : MonoBehaviour
{
    public float duration = 3f;
    Vector3 teleportPosition;
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
            teleportPosition.x = Random.Range(-5, 5);
            teleportPosition.y = Random.Range(-5, 5);
            transform.position = teleportPosition;
            progress = 0f;
        }
    }
}
