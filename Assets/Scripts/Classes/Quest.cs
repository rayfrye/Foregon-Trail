using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public string Description;
    [SerializeField]
    public bool IsUnlocked;
    [SerializeField]
    public List<Event> MinorEvents;
    [SerializeField]
    public List<Event> MajorEvents;
    [SerializeField]
    public Event FinalEvent;
}
