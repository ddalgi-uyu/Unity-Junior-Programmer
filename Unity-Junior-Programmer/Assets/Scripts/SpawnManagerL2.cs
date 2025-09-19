using UnityEngine;

public class SpawnManagerL2 : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnsPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        animalIndex = Random.Range(0, animalsPrefabs.Length);
        Instantiate(animalsPrefabs[animalIndex], spawnsPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
