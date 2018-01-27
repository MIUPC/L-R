using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateInfiniteTerrain : MonoBehaviour
{
    public GameObject ground;
    public GameObject floor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            ground.transform.position = new Vector3(ground.transform.position.x, ground.transform.position.y, ground.transform.position.z + (ground.transform.localScale.z / 2 - 25));
        }
        if (other.GetComponent<PlayerMovement>() != null)
        {
            floor.transform.position = new Vector3(floor.transform.position.x, floor.transform.position.y, floor.transform.position.z + (floor.transform.localScale.z / 2 - 25));
        }
    }
}
