using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    [SerializeField]
    public int CurrentHealth;
    [SerializeField]
    public int MaxHealth;
    [SerializeField]
    public Profile Profile;
    [SerializeField]
    public Stats Stats;
    [SerializeField]
    public int Level;
    [SerializeField]
    public int Experience;
    [SerializeField]
    public Equipment[] Equipment = new Equipment[6];
}

