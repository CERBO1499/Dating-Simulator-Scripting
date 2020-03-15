using System.Collections;
using System.Collections.Generic;
using Enums;

using System;
using UnityEngine;

[Serializable]
public struct TargetTraits
{
    public Etrait preffered;
    public Etrait disliked;
    public Etrait hated;

    public Etrait RandomTrait()
    {
        Etrait theTrait = Etrait.Afecction;

        switch (UnityEngine.Random.Range(0, 3))
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
}
