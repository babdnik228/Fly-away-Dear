using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool is_up;
    public bool is_left;
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        Controler controler = collision.GetComponent<Controler>();
        if(controler != null)
        {
            if(is_up == true)
            {
            controler.GetComponent<Rigidbody2D>().AddForce(transform.up * 55f);
            }
            if (is_left == true)
            {
                controler.GetComponent<Rigidbody2D>().AddRelativeForce(-transform.right * 185f);
            }
        }
    }
}
