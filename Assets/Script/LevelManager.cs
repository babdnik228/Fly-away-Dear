using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager_singolton;
    //
    public bool is_lose;
    public bool is_finish;
    private void Start()
    {
        levelManager_singolton = this;
    }
}
