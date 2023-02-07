using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Action
{
    [SerializeField]
    public string Name;
    
    [SerializeField]
    public List<Trait> Traits;

    [SerializeField]
    public StatType StatType;
    [SerializeField]
    public int Level;
}

