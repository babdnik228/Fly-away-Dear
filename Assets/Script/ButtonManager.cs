using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string nameSceneRestart;
    [SerializeField] private string sceneExitToMenu;
    public void RestartLevel()
    {
        SceneManager.LoadScene(nameSceneRestart);
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene(sceneExitToMenu);
    }
}
