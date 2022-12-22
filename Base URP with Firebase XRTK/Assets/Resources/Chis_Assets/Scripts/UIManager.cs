/*
 * Author: Lucas Dominic Tiu
 * Date: 12/18/2022
 * Description: Contains the scripts and variables for all the UI within the gmae scene
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("WinterRoom")]
    public TextMeshProUGUI pinScore;
    private int pinScoreVal;

    [Header("AutumnRoom")]
    public TextMeshProUGUI leafScore;
    private int leafScoreVal;

    [Header("SummerRoom")]
    public TextMeshProUGUI fruitScore;
    private int fruitScoreVal;

    [Header("SpringRoom")]
    public TextMeshProUGUI rabbitScore;
    private int rabbitScoreVal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///Winter ScoreDisplay
        pinScoreVal = pinsCount.pinCount;
        pinScore.text = "Pin Counter: " + pinScoreVal.ToString();

        ///Autumn ScoreDisplay
        leafScoreVal = drainCollide.leafCount;
        leafScore.text = "Leaf Count: " + leafScoreVal.ToString();

        ///Summer ScoreDisplay
        fruitScoreVal = Katanas.fruitsDestroyed;
        fruitScore.text = "Fruits Ninja'd: " + fruitScoreVal.ToString();

        ///Spring ScoreDisplay
        rabbitScoreVal = animalsSpawner.rabbitCount;
        rabbitScore.text = "Rabbits Hunted: " + rabbitScoreVal.ToString();
    }
}
