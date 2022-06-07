using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string nameSceneRestart;
    [SerializeField] private string sceneExitToMenu;
    [SerializeField] private string cont_scene;
    public void RestartLevel()
    {
        SceneManager.LoadScene(nameSceneRestart);
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene(sceneExitToMenu);
    }
    public void ContinueLevel()
    {
        SceneManager.LoadScene(cont_scene);
    }
}
