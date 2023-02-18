using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionResult
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public int InflictsHealth;
    [SerializeField]
    public List<Trait> InflictsTraits;
    [SerializeField]
    public int TargetRoll;
}

