using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fight : Event
{
    [SerializeField]
    public int CurrentHealth;
    [SerializeField]
    public int MaxHealth;
}
