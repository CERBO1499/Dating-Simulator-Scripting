using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Hater : Target, IHaterInter
{
    public override void Begin(float e, float i)
    {
        base.Begin(e, i);
    }

    public override void Begin(float e, float i, Etrait p, Etrait d, Etrait h)
    {
        base.Begin(e, i, p, d, h);
    }

    public Etrait Hated { get; set; }

}
