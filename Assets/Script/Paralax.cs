using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] private float speed_Paralax;
    [SerializeField] private float endX;
    [SerializeField] private float startX;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.Translate(Vector2.left * speed_Paralax * Time.deltaTime);
        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, 0);
            transform.position = pos;
        }
    }
}
