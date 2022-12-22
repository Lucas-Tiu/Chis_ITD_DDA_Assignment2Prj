using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    [SerializeField] private bool hasMango;

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasMango && collision.transform.tag == "Mango")
        {
            FindObjectOfType<boxParent>().count++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (hasMango && collision.transform.tag == "Mango")
        {
            FindObjectOfType<boxParent>().count--;
        }
    }

}
