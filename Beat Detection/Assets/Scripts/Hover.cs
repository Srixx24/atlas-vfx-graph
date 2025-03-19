using UnityEngine;

public class Hover : MonoBehaviour
{
    public float hoverHeight = 0.5f;
    public float hoverSpeed = 2.0f;
    public float offset;
    private Vector3 startPosition;


    void Start()
    {
        startPosition = transform.position;
        offset = Random.Range(0f, 2 * Mathf.PI); // Random offset for staggering
    }

    void Update()
    {
        // Calculate new Y position
        float newY = startPosition.y + Mathf.Sin(Time.time * hoverSpeed + offset) * hoverHeight;
        
        // Apply new position keep X and Z values
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
