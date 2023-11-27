using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cubeObjectPrefab;
    public GameObject pickUpsPrefab;
    public GameObject spawnPoint;

    private float spawnRange = 6;
    private float spawnPos = 80;
    private float startDelay = 2;
    private float spawnInterval = 1f;
    private float pickupDelay = 10;
    private float pickupSpawnInterval = 16f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", startDelay, spawnInterval);
        InvokeRepeating("SpawnPickUps", pickupDelay, pickupSpawnInterval);
        InvokeRepeating("increaseSpawnRate", 10f, 20f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Using instantiation and var variables we can now spawn the objects we want into our scene while also performing the functions it needs to perform
    void SpawnObjects()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 1.04f, -spawnPos);
        var spawnPoint = Instantiate(cubeObjectPrefab, spawnPosition, cubeObjectPrefab.transform.rotation);
        spawnPoint.transform.parent = gameObject.transform;
    }

    void SpawnPickUps()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 1.04f, -spawnPos);
        var spawnPoint = Instantiate(pickUpsPrefab, spawnPosition, pickUpsPrefab.transform.rotation);
        spawnPoint.transform.parent = gameObject.transform;
    }
    //Method to increase the spawn rate of the cubes, unsure if it actually worked
    void increaseSpawnRate()
    {
        spawnInterval = spawnInterval -= 0.2f;
    }
}