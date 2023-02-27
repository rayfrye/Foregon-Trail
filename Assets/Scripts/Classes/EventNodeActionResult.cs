using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EventNodeActionResult
{
    [SerializeField]
    public EventNodeActionResultType EventNodeActionResultType;
    [SerializeField]
    public int HPImpact;
    [SerializeField]
    public int GoldImpact;
    [SerializeField]
    public int StatImpact;
    [SerializeField]
    public StatType StatType;
    [SerializeField]
    public EventNode EventNode;
}
