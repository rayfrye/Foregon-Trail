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
    public List<QuestEvent> MinorQuestEvents;
    [SerializeField]
    public List<QuestEvent> MajorQuestEvents;
    [SerializeField]
    public QuestEvent FinalQuestEvent;
}
