using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishObject : MonoBehaviour
{
    [SerializeField] private string nameScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Controler controler = collision.GetComponent<Controler>();
        if (controler != null)
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}
