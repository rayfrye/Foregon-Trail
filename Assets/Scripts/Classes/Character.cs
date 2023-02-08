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
    public List<Trait> TempTraits;
    [SerializeField]
    public Stats Stats;
    [SerializeField]
    public int Experience;
    [SerializeField]
    public List<Action> Actions;
    [SerializeField]
    public EquipmentGroup Equipped;
}

