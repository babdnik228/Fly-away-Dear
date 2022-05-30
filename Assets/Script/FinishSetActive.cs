using UnityEngine;

public class FinishSetActive : MonoBehaviour
{
    [SerializeField] private GameObject setActiveFinish;
    private void Update()
    {
        if(LevelManager.levelManager_singolton.is_finish == true)
        {
            setActiveFinish.SetActive(true);
        }
    }
}
