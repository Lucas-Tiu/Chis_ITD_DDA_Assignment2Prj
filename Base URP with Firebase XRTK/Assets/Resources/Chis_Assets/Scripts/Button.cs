/*
 * Author: Lucas Dominic Tiu
 * Date: 12/16/2022
 * Description: Script for a functional button to be clicked in unity to activate events
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource buttonClickAudio;
    bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        buttonClickAudio = GetComponent<AudioSource>(); ///Get audio source to play sound afterwards
        isPressed = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed) ///check that it is not pressed
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0); ///changes button to pressed position
            presser = other.gameObject;
            onPress.Invoke(); /// invoke onpress events
            buttonClickAudio.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.15f, 0);
            onRelease.Invoke(); /// invoke on release events
            isPressed = false;
        }
    }

}
