using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EventNode
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public List<string> Text;
    [SerializeField]
    public List<EventNodeAction> Actions;
}
