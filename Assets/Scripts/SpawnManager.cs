using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.triggered)
        {
            SpawnRandomAnimals();
        }
    }
    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-20, 20), 0, 20);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
