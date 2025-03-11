using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Material trail;
    public float speed = 2f;
    public float distance = 2f;
    


    void Start()
    {
        trail = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Get the mouse position
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;

        // Converts the position to world coordinates
        Vector3 mouseScreenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);

        // Interpolate trail towards mouse position
        Vector3 position = Vector3.Lerp(transform.position, mouseScreenToWorld, 1.0f - Mathf.Exp(-speed * Time.deltaTime));

        // Update trail
        transform.position = position;
    }
}
