using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject ObjectToBeSpawned;

    BoxCollider2D spawnArea;

    float elapsedTime = 0;
    public float spawnTime = 2;
    public float xAxis;
    public float yAxis;


	void Start ()
    {

        spawnArea = GetComponent<BoxCollider2D>();
		
	}

    public Vector3 PickPosition()
    {
        xAxis = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        yAxis = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
        return new Vector3(xAxis, yAxis, 0);
    }

    void SpawnObject()
    {
        Vector3 SpawnPlace = PickPosition();
        Instantiate(ObjectToBeSpawned, SpawnPlace, Quaternion.identity);
    }
	void Update ()
    {
        elapsedTime = elapsedTime + Time.deltaTime;
        if (elapsedTime > spawnTime)
        {
            SpawnObject();
            elapsedTime = 0;
        }
		
	}
}
