using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainSpawner : MonoBehaviour
{
    public List<GameObject> spawnPoints = new List<GameObject>();
    public float spawnRate;
    public GameObject train;
    public Vector3 direction;
    void spawnTrain()
    {
        int randomIndex = Mathf.FloorToInt( spawnPoints.Count * Random.value);
        GameObject spawnPosition = spawnPoints[randomIndex];

        GameObject currentTrain= Instantiate(train, spawnPosition.transform.position, Quaternion.identity);

        Trains trainComponent = currentTrain.GetComponent<Trains>();
        trainComponent.SetDirection(direction);
    }
    void RepeatSpawn()
    {
        spawnTrain();
        Invoke("RepeatSpawn", spawnRate);
    }
        
        // Start is called before the first frame update
    void Start()
    {
        RepeatSpawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
