using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class Target : MonoBehaviour
{
    public float minE = 0, maxE = 100, minI = 0, maxI = 100;

    [SerializeField] protected float expectation;

    [SerializeField] protected float interest;

    [SerializeField]
    protected TargetTraits traits;
    //private EChick chick;

    public float Interest { get => interest; private set { CheckLimits(value, 0, expectation); } }
    public float Expectation { get => expectation; }

    private void Awake()
    {
        Begin(1, 10);
    }

    protected virtual void Begin(float e, float i)
    {
        expectation = CheckLimits(e, minE, maxE);
        Interest = CheckLimits(i, minI, maxI);

        traits.preffered = traits.RandomTrait();
        traits.disliked = traits.RandomTrait();
        traits.hated = traits.RandomTrait();

        //AssignLimits();
        AssignTraits();

        ShowInterest();
    }
    protected virtual void Begin(float e, float i, Etrait pref, Etrait dis, Etrait hate)
    {
        expectation = CheckLimits(e, minE, maxE);
        Interest = CheckLimits(i, minI, maxI);

        traits.preffered = pref;
        traits.disliked = dis;
        traits.hated = hate;

        AssignTraits();
    }

    public void AddInterest(float cant)
    {
        Interest += cant;

        ShowInterest();
    }

    public void RestInterest(float cant)
    {
        Interest -= cant;

        ShowInterest();
    }

    private void ShowInterest()
    {
        UIMan.Instance.ShowInterest(interest);
    }

    public void Win()
    {

    }
    public void Lose()
    {
        
    }

    private float CheckLimits(float val, float min, float max)
    {
        return (val > max ? max : (val < min ? min : val));
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