/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: Katana manager
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katanas : MonoBehaviour
{

    public LayerMask layer;
    private Vector3 previousPos;
    public static int fruitsDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position-previousPos, hit.transform.up) > 130)
            {
                Destroy(hit.transform.gameObject);

                fruitsDestroyed++;
            }
        }
        previousPos = transform.position;
    }
}
