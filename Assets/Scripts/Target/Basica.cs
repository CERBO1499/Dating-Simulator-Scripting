using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Basica : Target, IBasicaInter
{
    protected override void Begin(float e, float i)
    {
        base.Begin(e, i);
    }

    protected override void Begin(float e, float i, Etrait p, Etrait d, Etrait h)
    {
        base.Begin(e, i, p, d, h);
    }

    protected override void AssignTraits()
    {
        Preffered = traits.preffered;
        Disliked = traits.disliked;
        Hated = traits.hated;
    }

    public Etrait Preffered { get; set; }
    public Etrait Disliked { get; set; }
    public Etrait Hated { get; set; }
}