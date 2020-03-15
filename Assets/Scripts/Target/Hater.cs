using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Hater : Target, IHaterInter
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
        Hated = traits.hated;
    }

    public Etrait Hated { get; set; }
}
