/*
 * Author: Lucas Dominic Tiu
 * Date: 12/18/2022
 * Description: Contains functions that will be used in the Menus (both main and pause menus)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{

    [Header("OptionsBtn")]
    [SerializeField] private Camera VRCam;
    private bool VRAudio = true;




    public void LoadGame()
    {
        SceneManager.LoadScene(2); ///Loads Scene Index 2 when Play button is clicked
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(1); ///Loads Scene Index 1 when Play button is clicked
    }

    public void RidAudio()
    {
        VRAudio = !VRAudio;
        VRCam.GetComponent<AudioListener>().enabled = VRAudio;
    }

    public void QuitButton()
    {
        Application.Quit(); ///Quit application 
    }
}
