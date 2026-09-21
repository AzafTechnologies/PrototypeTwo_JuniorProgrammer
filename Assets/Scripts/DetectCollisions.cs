
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once when the game starts.
    void Start()
    {
        
    }

    // Update is called once every frame.
    void Update()
    {
        
    }

    // Called when another collider enters this object's trigger area.
    private void OnTriggerEnter(Collider other)
    {
        // Destroy this GameObject when a collision occurs.
        Destroy(gameObject);

        // Destroy the GameObject that entered the trigger.
        Destroy(other.gameObject);
    }
}
