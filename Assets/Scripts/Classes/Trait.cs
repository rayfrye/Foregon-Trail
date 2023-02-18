using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Trait
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public bool IsPositive;
    [SerializeField]
    public Stats Stats;
}
