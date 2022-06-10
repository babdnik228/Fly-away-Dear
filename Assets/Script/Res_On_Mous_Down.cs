using UnityEngine;

public class Res_On_Mous_Down : MonoBehaviour
{
    [SerializeField] private GameObject[] basic_object;
    [SerializeField] private GameObject[] physic_object;
    [SerializeField] private GameObject effect;
    [SerializeField] private GameObject audio;
    private void OnMouseDown()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        Instantiate(audio, transform.position, Quaternion.identity);
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
