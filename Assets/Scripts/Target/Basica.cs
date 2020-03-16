using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Basica : Target, IFresaInter, IHaterInter
{
    /*
    private void Awake()
    {
        minE = 70;
        maxE = 100;

        minI = 55;
        maxI = 80;
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

    public Etrait Preffered { get; set; }
    public Etrait Disliked { get; set; }
    public Etrait Hated { get; set; }
}