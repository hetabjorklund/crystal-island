using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameovercode : MonoBehaviour
{
    void Start()
    {
        // show the points on the gameover screen
        int crystals = PlayerPrefs.GetInt("points");
        GameObject.Find("pointsText").GetComponent<Text>().text = "Crystals collected: " + crystals + "/70";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) { // if X is pressed, re-start the game
            SceneManager.LoadScene(1);
        }        
    }

}
