using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercode : MonoBehaviour
{
    private float location;
    public bool alive;
    
    void Start()
    {
        alive = true;
    }

    void Update()
    {
        location = this.GetComponent<Rigidbody>().worldCenterOfMass.z;

        // the player dies underwater i.e. if the z position < 115
        if (location < 115f) {
            alive = false;
        }
    }
    
}
