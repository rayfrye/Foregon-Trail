using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EventNodeAction
{
    [SerializeField]
    public string Label;
    [SerializeField]
    public string SubLabel;
    [SerializeField]
    public StatType StatType;
    [SerializeField]
    public EventNodeActionResult FullSuccess;
    [SerializeField]
    public EventNodeActionResult PartialSuccess;
    [SerializeField]
    public EventNodeActionResult CompleteFailure;
}