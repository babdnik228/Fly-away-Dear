using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishPanelActivator : MonoBehaviour
{

    [SerializeField] private GameObject PanelFinish;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Controler controler = collision.GetComponent<Controler>();
        if (controler != null)
        {
            PanelFinish.SetActive(true);
        }
    }
}
