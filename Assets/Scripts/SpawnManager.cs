
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    // Stores the animal prefabs that can be spawned.
    public GameObject[] animalPrefabs;

    // Input action used to manually spawn an animal.
    public InputAction spawnAction;

    // Maximum distance from the center on the X-axis.
    private float spawnRangeX = 20;

    // Fixed position where animals are spawned on the Z-axis.
    private float spawnPosZ = 20;

    // Time to wait before the first automatic spawn.
    private float startDelay = 2;

    // Time between each automatic spawn.
    private float spawnInterval = 1.5f;

    // Runs once when the game starts.
    void Start()
    {
        // Repeatedly spawn animals after the start delay.
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);

        // Enable the input action so it can detect player input.
        spawnAction.Enable();
    }

    // Runs once every frame.
    void Update()
    {
        // Check if the spawn input action was triggered.
        if (spawnAction.triggered)
        {
            // Spawn an animal when the input is triggered.
            SpawnRandomAnimals();
        }
    }

    // Selects a random animal and spawns it at a random position.
    void SpawnRandomAnimals()
    {
        // Select a random animal prefab from the array.
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Create a random spawn position within the X-axis range.
        Vector3 spawnPos = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Create the selected animal at the calculated position.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
