using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject ground;
    [Space(10)]
    public GameObject[] obstaclePrefabs;

    private void OnTriggerEnter(Collider other)
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        float maxWidht = ground.transform.localScale.x;
        float maxLength = ground.transform.localScale.z;

        float maxWidthRandom = UnityEngine.Random.Range(-maxWidht, maxWidht);
        //float maxLenghtRandom = UnityEngine.Random.Range(-maxLength, maxLength);

        int randomPrefab = UnityEngine.Random.Range(0, obstaclePrefabs.Length);

        GameObject obstacleObject;

        obstacleObject = Instantiate(obstaclePrefabs[randomPrefab],new Vector3(ground.transform.position.x  + maxWidthRandom,1,transform.position.z),Quaternion.identity);

    }
}
