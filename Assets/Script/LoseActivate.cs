using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseActivate : MonoBehaviour
{
    [SerializeField] private GameObject Panel_Lose;
    private void Update()
    {
        if(LevelManager.levelManager_singolton.is_lose == true)
        {
            StartCoroutine(Cor_Lose());
        }
    }
    private IEnumerator Cor_Lose()
    {
        yield return new WaitForSeconds(2f);
        Panel_Lose.SetActive(true);
    }
}
