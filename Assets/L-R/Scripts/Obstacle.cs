using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<PlayerMovement>() != null)
        {
            Debug.Log("We've hit the player!");

            col.gameObject.GetComponent<PlayerMovement>().enabled = false;
            col.rigidbody.velocity = new Vector3(0, 0, 0);
        }
    }
}
