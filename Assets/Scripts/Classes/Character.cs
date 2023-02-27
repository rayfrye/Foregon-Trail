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
    public int GetStatValue(StatType StatType)
    {
        switch(StatType)
        {
            case StatType.Strength:{
                return Stats.Strength;
            }
            case StatType.Dexterity:{
                return Stats.Dexterity;
            }
            case StatType.Intelligence:{
                return Stats.Intelligence;
            }
            case StatType.Wisdom:{
                return Stats.Wisdom;
            }
            case StatType.Constitution:{
                return Stats.Constitution;
            }
            case StatType.Charisma:{
                return Stats.Charisma;
            }
            default:{
                return 0;
            }
        }
    }
}

