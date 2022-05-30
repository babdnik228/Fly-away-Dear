using UnityEngine;

public class Lose : MonoBehaviour
{
    private void OnMouseDown()
    {
        LevelManager.levelManager_singolton.is_lose = true;
    }
}
