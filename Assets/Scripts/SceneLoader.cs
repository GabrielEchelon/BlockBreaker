using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private GameStatus gameStatus;

    public void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        gameStatus.ResetScore();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadWinScene()
    {
        SceneManager.LoadScene(2);
    }
}
