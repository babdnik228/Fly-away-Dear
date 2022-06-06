using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool is_up;
    public bool is_left;
    public bool is_right;
    //
    [SerializeField] private float up_power = 55f;
    [SerializeField] private float left_power = 185f;
    [SerializeField] private float right = 185f;


    private void OnTriggerStay2D(Collider2D collision)
    {
        Controler controler = collision.GetComponent<Controler>();
        if(controler != null)
        {
            if(is_up == true)
            {
            controler.GetComponent<Rigidbody2D>().AddForce(transform.up * up_power);
            }
            if (is_left == true)
            {
                controler.GetComponent<Rigidbody2D>().AddRelativeForce(-transform.right * left_power);
            }
            if (is_right == true)
            {
                controler.GetComponent<Rigidbody2D>().AddRelativeForce(transform.right * right);
            }
        }
    }
}
