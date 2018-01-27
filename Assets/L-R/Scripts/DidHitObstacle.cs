using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DidHitObstacle : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject highScoreManager;
    [Space(10)]
    public static bool isDead;

    private void Update()
    {

    }

    public void PlayerDie()
    {
        isDead = true;
        highScoreManager.GetComponent<HighscoreManager>().SaveHighScore();
        gameOverScreen.SetActive(true);
    }
}
