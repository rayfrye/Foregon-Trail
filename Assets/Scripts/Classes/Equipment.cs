using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Equipment : Item
{
    [SerializeField]
    public EquipmentSlot EquipmentSlot;

    [SerializeField]
    public Stats Stats;
    
}
