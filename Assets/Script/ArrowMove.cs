using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private Transform posx1;
    [SerializeField] private Transform pos2;
    [SerializeField] private GameObject arrow;
    private void Update()
    {
        StartCoroutine(Cor());
    }
    private IEnumerator Cor()
    {
        while (true)
        {
            arrow.transform.Translate(pos2.position * 1 * Time.deltaTime);
        yield return new WaitForSeconds(4f);
            arrow.transform.Translate(posx1.position * 1 * Time.deltaTime); ;
        }
    }
}
