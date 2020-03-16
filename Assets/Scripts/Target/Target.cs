using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using Bubbles;
using System;

public abstract class Target : MonoBehaviour
{
    public static event Action<bool> InLost;

    [SerializeField, Range(0,100)]
    protected float minE, maxE, minI, maxI;

    //[SerializeField]
    protected float expectation;
    //[SerializeField]
    protected float interest;

    [SerializeField] protected TargetTraits traits;

    [SerializeField] private float puntajeInterest;
    //private EChick chick;

    public float Interest { get => interest; 
        private set 
        {
            //interest = value;
            interest = CheckLimits(value, minI, maxI);
        } 
    }

    public float Expectation { get => expectation; private set { expectation = CheckLimits(value, minE, maxE); } }

    private void Awake()
    {
        Bubble.InBubblePop += AddInterest;

        BubbleKiller.InHurt += RestInterest;

        Begin(500, 10);
    }

    protected virtual void Begin(float e, float i)
    {
        Expectation = e;
        Interest = i;

        traits.preffered = traits.RandomTrait();
        traits.disliked = traits.RandomTrait();
        traits.hated = traits.RandomTrait();

        AssignTraits();

        ShowInterest();
    }
    protected virtual void Begin(float e, float i, Etrait pref, Etrait dis, Etrait hate)
    {
        expectation = CheckLimits(e, minE, maxE);
        interest = CheckLimits(i, minI, maxI);

        traits.preffered = pref;
        traits.disliked = dis;
        traits.hated = hate;

        AssignTraits();
    }

    public void AddInterest(Etrait trait)
    {
        if(trait==Etrait.Intimacy)
        {
            Interest += puntajeInterest;
        }
       

        ShowInterest();
    }

   

    public void RestInterest(float cant)
    {
        interest -= cant;

        ShowInterest();

        if (Interest <= 0) Lose();
    }

    private void ShowInterest()
    {
        UIMan.Instance.ShowInterest(Interest);
    }

    public void Win()
    {

    }
    public void Lose()
    {
        InLost(true);
       // UIMan.Instance.LoseOn(true);
       cambioEscena.Instance.GameOver();
    }

    private float CheckLimits(float val, float min, float max)
    {
        return (val > max) ? max : (val < min) ? min : val;
    }


    protected void AssignTraits()
    {
        Preffered = traits.preffered;
        Disliked = traits.disliked;
        Hated = traits.hated;
    }

    private Etrait Preffered { get; set; }
    private Etrait Disliked { get; set; }
    private Etrait Hated { get; set; }
}