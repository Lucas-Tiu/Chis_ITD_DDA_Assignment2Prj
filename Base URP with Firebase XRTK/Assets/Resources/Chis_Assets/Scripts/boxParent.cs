using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boxParent : MonoBehaviour
{
    public int count;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Mango")
        {
            count++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Mango")
        {
            count -= 1;
        }
    }
    private void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if (count >= 4)
        {
            backToMainMenu();
        }
    }
}
