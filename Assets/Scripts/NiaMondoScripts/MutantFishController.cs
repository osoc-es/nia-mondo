﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantFishController : MonoBehaviour
{

    public LevelLoader levelLoader;

    public Platformer.Mechanics.Health playerHealth;

    public  AudioSource audioSource;



    public void Atack(){
        
        audioSource.Play();
        StartCoroutine(removeHP());

    }

    IEnumerator removeHP(){
        //Aqui quitas vida
        //vida player %50
        playerHealth.FishAtack();


        yield return new WaitForSeconds(2f);

        levelLoader.LoadNextLevel();
    }
}