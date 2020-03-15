using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Hater : Target, IHaterInter
{
    /*
    private void Awake()
    {
        minE = 55;
        maxE = 80;

        minI = 10;
        maxI = 30;
    }
    */

    protected override void Begin(float e, float i)
    {
        base.Begin(e, i);
    }

    protected override void Begin(float e, float i, Etrait p, Etrait d, Etrait h)
    {
        base.Begin(e, i, p, d, h);
    }

    public Etrait Hated { get; set; }

}
