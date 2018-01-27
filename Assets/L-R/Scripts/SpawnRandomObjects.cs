using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject ground;
    private float currentTime;
    [Space(10)]
    public float delayTimeSec;
    [Header("-------------------------------------------------------")]
    [Header("Try to use prefabs instead of objects in the scene!")]
    [Header("-------------------------------------------------------")]
    public GameObject[] obstaclePrefabs;

    private void OnTriggerEnter(Collider other)
    {
        SpawnObjects();
    }

    public void Update()
    {
        currentTime += Time.deltaTime * delayTimeSec;
    }

    void SpawnObjects()
    {

        if (currentTime >= delayTimeSec)
        {
            currentTime = 0;

            //float maxWidht = ground.transform.localScale.x;
            //float maxLength = ground.transform.localScale.z;

            float maxWidthRandom = UnityEngine.Random.Range(-10, 10);
            //float maxLenghtRandom = UnityEngine.Random.Range(-maxLength, maxLength);

            int randomPrefab = UnityEngine.Random.Range(0, obstaclePrefabs.Length);

            GameObject obstacleObject;

            obstacleObject = Instantiate(obstaclePrefabs[randomPrefab], new Vector3(ground.transform.position.x + maxWidthRandom, 1, transform.position.z), Quaternion.identity);
        }

    }
}
