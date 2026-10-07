using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("1.MainMenu");
    }
    public void LoadGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void LoadResults()
    {
        SceneManager.LoadScene("Results");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
