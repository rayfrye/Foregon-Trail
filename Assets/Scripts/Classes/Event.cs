using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Event
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public string Description;
    [SerializeField]
    public List<string> Text;
    [SerializeField]
    public int ExperienceReward;
    [SerializeField]
    public int GoldReward;
    [SerializeField]
    public List<Item> ItemReward;
}