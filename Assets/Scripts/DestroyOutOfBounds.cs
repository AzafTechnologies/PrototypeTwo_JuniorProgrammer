
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // The maximum Z position an object can reach before it is destroyed.
    public float topBound = 25.0f;

    // The minimum Z position an object can reach before it is destroyed.
    public float lowerBound = -10.0f;

    // Start is called once when the game starts.
    void Start()
    {

    }

    // Update is called once every frame.
    void Update()
    {
        // Check if the object has moved beyond the top boundary.
        if (transform.position.z > topBound)
        {
            // Destroy the object when it goes beyond the top boundary.
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Display a Game Over message when the object goes below the lower boundary.
            Debug.Log("Game Over!");

            // Destroy the object when it goes below the lower boundary.
            Destroy(gameObject);
        }
    }
}
