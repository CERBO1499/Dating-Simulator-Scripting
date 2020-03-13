using System;
using System.Collections;
using System.Collections.Generic;
using Bubbles;
using Enums;
using UnityEngine;

public class BubbleKiller : MonoBehaviour
{

    private int countLose;
    [SerializeField] private int Umbral;
    private ParticleSystem parSys;
    private AudioSource aud;
    private void Awake()
    {
        parSys = GetComponentInChildren<ParticleSystem>();
        aud = GetComponent<AudioSource>();
    }
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bubble")
        {
            Bubble bl = other.gameObject.GetComponent<Bubble>();


            if (bl.Trait == Etrait.Love || bl.Trait == Etrait.Intelligence || bl.Trait == Etrait.Filrt)
            {
                print(bl.Trait);
                countLose++;
                if (countLose >= Umbral)
                {
                    parSys.Play();
                    print("Qiotando vida");
                    //Quite vida
                }
            }

            bl.Die(); 
            
            
        }
    }
    
    
}
