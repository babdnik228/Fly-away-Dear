using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickStolb : MonoBehaviour
{
    [SerializeField] private GameObject next_stolb;
    private void OnMouseDown()
    {
        next_stolb.SetActive(true);
    }
    
}
