using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject sole_effect;
    private void OnMouseDown()
    {
        Instantiate(sole_effect, transform.position, Quaternion.identity);
        LevelManager.levelManager_singolton.is_lose = true;
    }
}
