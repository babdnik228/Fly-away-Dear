using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseObstacle : MonoBehaviour
{
    [SerializeField] private GameObject lose_panel;
    [SerializeField] private GameObject effect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Controler controler = collision.gameObject.GetComponent<Controler>();
        if (controler != null)
        {
            StartCoroutine(Cor_Lose());
        }
    }
    private IEnumerator Cor_Lose()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        lose_panel.SetActive(true);
    }
}
