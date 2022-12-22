/*
 * Author: Lucas Dominic Tiu
 * Date: 12/20/2022
 * Description: spawns the fruits to be destroyed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] fruitsArray;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float beatValue;
    [SerializeField] AudioSource fruitAudioSource;
    [SerializeField] AudioClip unitySong;
    private bool fruitSpawnBool = false;
    private float timer;
    public static int fruitSpawnStop = 0;
    public void startFruitSpawner()
    {
        fruitSpawnBool = true;
        fruitAudioSource.PlayOneShot(unitySong);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beatValue && fruitSpawnBool == true)
        {
            GameObject fruits = Instantiate(fruitsArray[Random.Range(0, 2)], spawnPoints[Random.Range(0, 4)]);
            fruits.transform.localPosition = Vector3.zero;
            fruits.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beatValue;
        }

        timer += Time.deltaTime;

        if (fruitSpawnStop == 1)
        {
            this.enabled = false;
        }
    }
}
