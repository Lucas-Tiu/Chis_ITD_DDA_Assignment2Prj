/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: counts the number of leaves that have been swept into the drainage
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class drainCollide : MonoBehaviour
{
    public static int leafCount = 0;


    private void OnTriggerEnter(Collider other)
    {
        leafCount++;
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
