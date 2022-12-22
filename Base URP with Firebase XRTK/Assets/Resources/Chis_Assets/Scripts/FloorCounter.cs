/*
 * Author: Lucas Dominic Tiu
 * Date: 12/16/2022
 * Description: COntains scripts managing the bowling alley
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCounter : MonoBehaviour
{
    public Transform pinParent;
    public GameObject pinParentPrefab;

    public GameObject ballRackPrefab;
    public Transform ballRack;

    public void Start()
    {
        ResetFloor();
        makeBall();
    }

    public void ResetFloor()
    {
        var pos = pinParent.position;
        var rot = pinParent.rotation;
        Destroy(pinParent.gameObject);

        StartCoroutine(pinSpawn(pos, rot));
    }

    public void makeBall()
    {
        Instantiate(ballRackPrefab, ballRack.position, Quaternion.identity);
    }

    private IEnumerator pinSpawn(Vector3 pos, Quaternion rot)
    {
        yield return new WaitForSeconds(1f);

        var newPins = Instantiate(pinParentPrefab, pos, rot);

        pinParent = newPins.transform;


    }
}
