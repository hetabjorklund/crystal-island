using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crystalcode : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name.Equals("Player")) { // if the player hits a crystal
            GameObject.Find("CrystalSound").GetComponent<AudioSource>().Play(); // play sound effect
            GameObject.Find("Code Storage").GetComponent<pointsandtimecode>().points += 1; // increase points
            Destroy(this.gameObject); // destroy crystal
        }
    }
    
}
