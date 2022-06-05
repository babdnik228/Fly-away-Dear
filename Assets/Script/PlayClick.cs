using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Cor_Start());
    }
    IEnumerator Cor_Start()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
