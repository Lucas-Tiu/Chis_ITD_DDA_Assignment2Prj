/*
 * Author: Lucas Dominic Tiu
 * Date: 12/16/2022
 * Description: Spawning of the leaves to be swept
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autumnLeaves : MonoBehaviour
{
    [Header("Leaf Spawn")]
    [SerializeField] private float _spawnX;
    [SerializeField] private float _spawnY;
    [SerializeField] private float _spawnZ;
    [SerializeField] private float _scaleValue;
    [SerializeField] private float _rotationValue;

    [SerializeField] private GameObject[] leavesArray;
    private Vector3 leafPos;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 30; i++) /// for loop to spawn number of leaves to sweep through
        {
            int leafIndex = Random.Range(0, 4);

            GameObject newLeaf = Instantiate(leavesArray[leafIndex], leafPos, Quaternion.Euler(0, Random.Range(-_rotationValue, _rotationValue), 0)); ///instantiates leaves
            float randomScaleValue = Random.Range(5, _scaleValue); ///randomizes the scale

            newLeaf.transform.localScale = new Vector3(randomScaleValue, 0, randomScaleValue); ///controls scale of prefabs spawned, y value remains as 0 to prevent scale flipping

            leafPos = transform.position + new Vector3(Random.Range(-_spawnX, _spawnX), Random.Range(-_spawnY, _spawnY), Random.Range(-_spawnZ, _spawnZ)); ///controls position of prefabs spawned
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
