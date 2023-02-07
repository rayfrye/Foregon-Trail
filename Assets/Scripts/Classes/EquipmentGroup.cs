using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct EquipmentGroup
{
    [SerializeField]
    public Equipment Head;
    [SerializeField]
    public Equipment Body;
    [SerializeField]
    public Equipment Hands;
    [SerializeField]
    public Equipment Legs;
    [SerializeField]
    public Equipment Feet;
}
