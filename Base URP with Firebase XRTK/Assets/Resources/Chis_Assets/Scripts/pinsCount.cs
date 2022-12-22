/*
 * Author: Lucas Dominic Tiu
 * Date: 12/16/2022
 * Description: Pin Counter
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinsCount : MonoBehaviour
{
    public static int pinCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag ==  "Floor")
        {
            pinCount++;
            Debug.Log(pinCount);
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
