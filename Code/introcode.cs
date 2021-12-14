using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introcode : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey) { // if any key is pressed, move to the main scene
            SceneManager.LoadScene(1);
        }        
    }

}
