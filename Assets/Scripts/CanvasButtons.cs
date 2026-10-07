using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        LevelManager.Instance.LoadMainMenu();
    }

    public void GoToGameplay()
    {
        LevelManager.Instance.LoadGameplay();
    }

    public void CallItQuits()
    {
        LevelManager.Instance.QuitGame();
    }
}
