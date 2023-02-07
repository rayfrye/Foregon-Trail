using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Trait
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public Stats Stats;
    [SerializeField]
    public int Duration;
}
