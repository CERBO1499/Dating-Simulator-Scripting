using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

interface ITargetInter
{
}

interface IFresaInter
{
    Etrait Preffered { get; set; }
    Etrait Disliked { get; set; }
}
interface IBasicaInter
{
    Etrait Preffered { get; set; }
    Etrait Disliked { get; set; }
    Etrait Hated { get; set; }
}
interface IHaterInter
{
    Etrait Hated { get; set; }
}