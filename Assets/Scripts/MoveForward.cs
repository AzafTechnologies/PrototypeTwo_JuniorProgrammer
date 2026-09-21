
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Controls how fast the object moves forward.
    public float speed = 40.0f;

    // Start is called once when the game starts.
    void Start()
    {

    }

    // Update is called once every frame.
    void Update()
    {
        // Move the object forward at a consistent speed.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
