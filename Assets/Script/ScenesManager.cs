﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public string enterScene;
    public string escapeScene;
    public bool isEscapeForQuit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Name Scene: " + enterScene);
            SceneManager.LoadScene(enterScene);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeForQuit)
            {
                Application.Quit();
            }

            else
            {
                Debug.Log("Name Scene: " + escapeScene);
                SceneManager.LoadScene(escapeScene);
            }
        }
        
    }
}
