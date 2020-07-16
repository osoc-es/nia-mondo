﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

            //LoadNextLevel();
        }
        else if(Input.GetKeyDown(KeyCode.E))
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));

    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Close");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    public void LoadControls(){
         StartCoroutine(LoadLevel(3));
    }

    public void BackToMenu(){
        StartCoroutine(LoadLevel(0));
    }
}
