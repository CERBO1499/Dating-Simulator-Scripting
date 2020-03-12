using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Target : MonoBehaviour
{
 /*   protected float expectation;

    [SerializeField]
    protected TargetTraits traits;
    //private EChick chick;

    public float Interest { get => Interest ; private set { CheckInterest(value, 0, expectation); } }
    public float Expectation { get => expectation; }

    protected virtual void Begin(float e, float i)
    {
        expectation = e;
        Interest = i;
    }
    protected virtual void Begin(float e, float i, Etrait p, Etrait d, Etrait h)
    {
        Begin(e,i);

        traits.preffered = p;
        traits.disliked = d;
        traits.hated = h;

        AssignTraits();
    }

    public void AddInterest(float cant)
    {
        Interest += cant;
    }

    public void RestInterest(float cant)
    {
        Interest -= cant;
    }

    public void Win()
    {

    }
    public void Lose()
    {

    }

    private float CheckInterest(float val, float min, float max)
    {
        if (val <= min) Lose();
        else if (val >= max) Win();
        return val;
    }

    public Etrait RandomTrait()
    {
        Etrait theTrait = Etrait.Afecction;

        switch (Random.Range(0, 3))
        {
            case 0:
                theTrait = Etrait.Filrt;
                break;
            case 1:
                theTrait = Etrait.Intelligence;
                break;
            case 2:
                theTrait = Etrait.Love;
                break;
        }

        return theTrait;
    }

    protected abstract void AssignTraits();*/
}