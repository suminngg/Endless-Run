using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int count = 0;
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && count > -2)
        {
            count--;
            transform.position += Vector3.left;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) && count < 2)
        {
            count++;
            transform.position += Vector3.right;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tire Stack")
        {
            animator.SetTrigger("Death");
        }
    }

}
