using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 25.0f;
    public float lowerBound = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound) { 
            Destroy(gameObject);
        }
    }
}

