using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void endGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
