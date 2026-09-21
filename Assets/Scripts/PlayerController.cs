
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Input action used to control the player's movement.
    public InputAction moveAction;

    // Stores the player's current movement input.
    public Vector2 moveInput;

    // Controls how fast the player moves.
    public float speed = 10.0f;

    // Defines the maximum horizontal movement range.
    public float xRange = 15.0f;

    // Stores the projectile prefab that the player can fire.
    public GameObject projectileObject;

    // Input action used to fire a projectile.
    public InputAction fireAction;

    // Start is called once when the game starts.
    void Start()
    {
        // Enable the movement input action.
        moveAction.Enable();

        // Enable the firing input action.
        fireAction.Enable();
    }

    // Update is called once every frame.
    void Update()
    {

        // Check if the player has moved beyond the left boundary.
        if (transform.position.x < -xRange)
        {
            // Keep the player inside the left movement boundary.
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            // Keep the player inside the right movement boundary.
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Read the current movement input from the input action.
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the player horizontally based on the input.
        transform.Translate(Vector3.right * speed * Time.deltaTime * moveInput.x);

        // Check if the fire input was triggered.
        if (fireAction.triggered)
        {
            // Create a new projectile at the player's current position.
            Instantiate(projectileObject, transform.position, projectileObject.transform.rotation);
        }
    }
}
