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
    public bool IsCompleted;
    [SerializeField]
    public QuestType QuestType;
    [SerializeField]
    public QuestEvent QuestEvent;
}
