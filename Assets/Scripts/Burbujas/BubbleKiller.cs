using System;
using System.Collections;
using System.Collections.Generic;
using Bubbles;
using Enums;
using UnityEngine;

public class BubbleKiller : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bubble")
        {
            Bubble bl = other.gameObject.GetComponent<Bubble>();
            switch (bl.Trait)
            {
                case Etrait.Love:
                case Etrait.Intelligence:
                case Etrait.Filrt:
                    break;
                default:
                    break;
                    
            }
            bl.Die(); 
            
            
        }
    }
    
    
}
