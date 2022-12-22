/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: Manages the speed at which the fruits float at you
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitMove : MonoBehaviour
{
    [SerializeField] private float fruitMoveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * fruitMoveSpeed;
    }
}
