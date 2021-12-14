using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pointsandtimecode : MonoBehaviour
{
    public int points = 0;
    public GameObject numberofcrystals = null;

    void Update()
    {
        // show the points on the main screen
        this.numberofcrystals.GetComponent<Text>().text = this.points + "/70";

        // if all the crystals are collected or the player dies
        if (this.points == 70 || GameObject.Find("Player").GetComponent<playercode>().alive == false) {
            PlayerPrefs.SetInt("points", this.points);
            SceneManager.LoadScene(2); // move to the gameover scene
        }
    }

}
