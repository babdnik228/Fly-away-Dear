using UnityEngine;

public class Res_On_Mous_Down : MonoBehaviour
{
    [SerializeField] private GameObject[] basic_object;
    [SerializeField] private GameObject[] physic_object;
    private void OnMouseDown()
    {
        for (int i = 0; i < basic_object.Length; i++)
        {
            basic_object[i].SetActive(false);
        }
        for (int i = 0; i < physic_object.Length; i++)
        {
            physic_object[i].SetActive(true);
        }
    }
}
