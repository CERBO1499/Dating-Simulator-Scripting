using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class Target : MonoBehaviour
{
    public const float e0Min = 0, e0Max = 1, i0Min = 0, i0Max = 1;

    [SerializeField] [Range(e0Min, e0Max)] protected float expectation;

    [SerializeField] [Range(i0Min, i0Max)] protected float interest;

    [SerializeField]
    protected TargetTraits traits;
    //private EChick chick;

    public float Interest { get => interest; private set { CheckInterest(value, 0, expectation); } }
    public float Expectation { get => expectation; }

    protected virtual void Begin(float e, float i)
    {
        expectation = e;
        Interest = i;

        traits.preffered = RandomTrait();
        traits.disliked = RandomTrait();
        traits.hated = RandomTrait();

        AssignLimits();
        AssignTraits();
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
    public float Lose()
    {
        return 1;
    }

    private float CheckInterest(float val, float min, float max)
    {
        return (val > max ? max : (val < min ? Lose() : val));
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

    protected abstract void AssignTraits();

    protected void AssignLimits()
    {
    }
}