using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{

    private Rigidbody rb;
    private bool isGrounded;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //AutoLaunch();

    }

    // For Testing
    private void AutoLaunch()
    {
        rb.AddForce(Vector3.left * 8000);
    }

    private void FixedUpdate()
    {
        /*Debug.Log(rb.velocity.sqrMagnitude);*/
        if (rb.velocity.sqrMagnitude < 0.6 || !isGrounded) return; 
        transform.localScale += (Vector3.one * 0.1f) * rb.velocity.sqrMagnitude * Time.fixedDeltaTime;
        Debug.Log((Vector3.one * 0.1f) * rb.velocity.sqrMagnitude * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Floor" && !isGrounded)
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Floor" && isGrounded)
        {
            isGrounded = false;
        }
    }

}
