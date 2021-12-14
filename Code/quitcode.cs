using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitcode : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { // if ESC is pressed, quit the game
            Application.Quit();
        }        
    }

}
