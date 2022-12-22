/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: Increase count of score when animals get hit
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalCollide : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {
            animalsSpawner.rabbitCount++;
            Debug.Log(animalsSpawner.rabbitCount);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
