using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startPos;
    public GameObject cam;  // Reference to the camera
    public float parallaxFactor;  // Determines the movement speed of the background layer

    void Start()
    {
        startPos = transform.position.x;  // Store the starting position of the background layer
        length = GetComponent<SpriteRenderer>().bounds.size.x;  // Get the width of the background sprite
    }

    void Update()
    {
        // Calculate how much the camera has moved relative to the background
        float temp = (cam.transform.position.x * (1 - parallaxFactor));
        float distance = (cam.transform.position.x * parallaxFactor);

        // Move the background layer
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        // Loop the background to create an infinite scrolling effect
        if (temp > startPos + length) startPos += length;
        else if (temp < startPos - length) startPos -= length;
    }
}
