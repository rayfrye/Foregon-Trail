using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public Character()
    {

    }

    [SerializeField]
    public string FirstName;
    [SerializeField]
    public string LastName;
    public string FullName => $"{FirstName} {LastName}";
    [SerializeField]
    public CharacterClass CharacterClass;
    [SerializeField]
    public CharacterStats stats;

    [System.Serializable]
    public struct CharacterStats
    {
        [SerializeField]
        public int BaseStrength;
    }
}
