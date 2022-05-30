using UnityEngine;

public class Res_On_Mous_Down : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
