/*
 * Author: Lucas Dominic Tiu
 * Date: 12/16/2022
 * Description: Script managing the overall game functions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class GameManager : MonoBehaviour
{

    [Header("Gun")]
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPt;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gunShotAudio;

    [Header("Flowers")]
    [SerializeField] private GameObject[] flowersArray;
    [SerializeField] private Transform[] spawnFlowerArray;
    [SerializeField] private AudioClip flowerSpawnAudio;
    [SerializeField] private AudioSource flowerAudioSources;
    private bool spawnAutumnOnce = true;
    private bool spawnSummerOnce = true;
    private bool spawnSpringOnce = true;
    private bool spawnWinterOnce = true;

    [Header("Game")]
    [SerializeField] private int objectiveCount;
    [SerializeField] private AudioClip winAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    async void Update()
    {
        if (objectiveCount >= 4)
        {
            flowerAudioSources.PlayOneShot(winAudio);
            var milliseconds = 3000;
            Thread.Sleep(milliseconds); ///delay for 3s before loading the scene
            SceneManager.LoadScene(2);
        }

        if (drainCollide.leafCount >= 10 && spawnAutumnOnce == true)
        {
            int autumn = 0;
            Instantiate(flowersArray[autumn], spawnFlowerArray[autumn].position, Quaternion.identity);
            flowerAudioSources.PlayOneShot(flowerSpawnAudio);
            spawnAutumnOnce = false;
        }

        if (Katanas.fruitsDestroyed >= 100 && spawnSummerOnce == true)
        {
            int summer = 1;
            fruitSpawner.fruitSpawnStop = 1;
            Instantiate(flowersArray[summer], spawnFlowerArray[summer].position, Quaternion.identity);
            flowerAudioSources.PlayOneShot(flowerSpawnAudio);
            spawnSummerOnce = false;
        }

        if (animalsSpawner.rabbitCount >= 5 && spawnSpringOnce == true)
        {
            int spring = 2;
            Instantiate(flowersArray[spring], spawnFlowerArray[spring].position, Quaternion.identity);
            flowerAudioSources.PlayOneShot(flowerSpawnAudio);
            spawnSpringOnce = false;
        }

        if(pinsCount.pinCount >= 21 && spawnWinterOnce == true)
        {
            int winter = 3;
            Instantiate(flowersArray[winter], spawnFlowerArray[winter].position, Quaternion.identity);
            flowerAudioSources.PlayOneShot(flowerSpawnAudio);
            spawnWinterOnce = false;
        }
    }
    
    public void objectiveCollected()
    {
        objectiveCount++;
    }

    /// <summary>
    /// Gun fire function through instatiation at transform point
    /// </summary>
    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bulletPrefab, shootPt.position, shootPt.rotation); ///Instantiate bullet at rotation and position of the transform of where I place the barrel gameobject
        spawnedBullet.GetComponent<Rigidbody>().velocity = bulletSpeed * shootPt.forward; ///Controls the velocity and direction at which the instantiated object travels
        audioSource.PlayOneShot(gunShotAudio); ///plays gunshot audio
        Destroy(spawnedBullet, 2); ///Destroy bullet after x seconds
        
    }
}
