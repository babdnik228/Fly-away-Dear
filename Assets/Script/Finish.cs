using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnMouseDown()
    {
        LevelManager.levelManager_singolton.is_finish = true;
    }
}
