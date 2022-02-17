using System;
using System.Collections;
using System.Collections.Generic;using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class collisionDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "level 1")
        {
            
            this.GetComponent<fly>().enabled = true;
            this.GetComponent<fly2>().enabled = false;
            
                if (col.gameObject.tag == "Spike")
                {
                    transform.position = new Vector3(-2.07f, 1.11f, -3.57f);
                }
            

        }
        else if (sceneName == "level 2")
        {
            this.GetComponent<fly>().enabled = false;
            this.GetComponent<fly2>().enabled = true;
                if (col.gameObject.tag == "Spike")
                {
                    transform.position = new Vector3(7.58f, 3.19f, -4.841f);
                }
            
        }

    }
}

