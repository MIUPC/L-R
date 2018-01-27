using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateInfiniteTerrain : MonoBehaviour
{
    public GameObject ground;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            ground.transform.position = new Vector3(ground.transform.position.x, ground.transform.position.y, ground.transform.position.z + (ground.transform.localScale.z / 2 - 25));
        }
    }
}
