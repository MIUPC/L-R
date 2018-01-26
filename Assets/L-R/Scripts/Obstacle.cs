using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<PlayerMovement>() != null)
        {
            Debug.Log(name + " has hit the player!");

            col.gameObject.GetComponent<PlayerMovement>().enabled = false;
            //col.rigidbody.velocity = new Vector3(0, 0, 0);
            col.gameObject.GetComponent<DidHitObstacle>().PlayerDie();
            //col.gameObject.transform.GetChild(0).parent = null;
            try
            {
                col.gameObject.transform.Find("Main Camera").parent = null;
            }
            catch(System.Exception ex)
            {
                if (!DidHitObstacle.isDead)
                {
                    Debug.LogError("Main Camera could not be found on " + col.gameObject.name + ". Are you sure its named \"Main Camera?\"\n\nERROR:" + ex);
                    col.gameObject.transform.GetChild(0).parent = null;
                }
            }
        }
    }
}
