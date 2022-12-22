/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: Spawning of the animals for autumnRoom
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalsSpawner : MonoBehaviour
{
    [Header("FoxNRabeets")]
    [SerializeField] private GameObject foxPrefab;
    [SerializeField] private GameObject rabbitPrefab;
    [SerializeField] private float rabbitX_left;
    [SerializeField] private float rabbitX_right;
    [SerializeField] private float rabbitY;
    [SerializeField] private float rabbitZ;

    private Vector3 rabbitPosL;
    [SerializeField] public static int rabbitCount;

    public void spawnAnimals()
    {
        StartCoroutine(RabbitSpawnLeft());
    }

    /// <summary>
    /// Coroutine to prevent the rabbits from spawning too quickly on the left side 
    /// </summary>
    private IEnumerator RabbitSpawnLeft()
    {
        while (rabbitCount < 5)
        {
            Instantiate(rabbitPrefab, rabbitPosL, Quaternion.identity);
            rabbitPosL = transform.position + new Vector3(rabbitX_left, Random.Range(-rabbitY, rabbitY), Random.Range(-rabbitZ, rabbitZ));

            yield return new WaitForSeconds(Random.Range(1, 3));
        }
        
        foreach (var rabbit in FindObjectsOfType<animalCollide>())
        {
            Destroy(rabbit.gameObject);
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

    ///pls i dont want to code anymore Mr Elyas
    ///save me
    ///this is a cry for help 

}
