using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;


public class Fresa : Target, IFresaInter
{
    public override void Begin(float e, float i)
    {
        base.Begin(e, i);
    }

    public override void Begin(float e, float i, Etrait p, Etrait d, Etrait h)
    {
        base.Begin(e, i,p,d,h);
    }

    public Etrait Preffered { get; set; }
    public Etrait Disliked { get; set; }
}