using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour
{
    [SerializeField] private GameObject audio_prefab;
    public bool is_play;
    public bool is_exit;
    public bool is_mus;
    private void OnMouseDown()
    {
        Instantiate(audio_prefab, transform.position, Quaternion.identity);
        if(is_play == true)
        {
            StartCoroutine(Cor_Start());
        }
        if (is_exit == true)
        {
            StartCoroutine(Cor_Exit());
        }
        if (is_mus == true)
        {
            StartCoroutine(Cor_Mus());
        }
    }
    IEnumerator Cor_Start()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
    IEnumerator Cor_Exit()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
    }
    IEnumerator Cor_Mus()
    {
        yield return new WaitForSeconds(5);
      
    }
}
