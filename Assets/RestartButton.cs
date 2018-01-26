using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
	public void Restart ()
    {
        SceneManager.LoadScene(0);
	}
}
