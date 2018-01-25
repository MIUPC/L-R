using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DidHitObstacle : MonoBehaviour
{
    public GameObject gameOverScreen;
    [Space(10)]
    public static bool isDead;

    private void Update()
    {

    }

    public void PlayerDie()
    {
        gameOverScreen.SetActive(true);
    }
}
