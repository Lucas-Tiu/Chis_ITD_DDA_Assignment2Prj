/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: Manages the speed at which the animals move
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalMove : MonoBehaviour
{
    [SerializeField] private float animalMoveSpd = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * animalMoveSpd;
    }
}
