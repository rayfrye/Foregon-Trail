using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestEvent
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public QuestEventType QuestEventType;
    [SerializeField]
    public QuestEventState QuestEventState;
    [SerializeField]
    public string Description;
    [SerializeField]
    public List<string> IntroText;
    [SerializeField]
    public List<string> OutroText;
    [SerializeField]
    public int ExperienceReward;
    [SerializeField]
    public int GoldReward;
    [SerializeField]
    public List<Item> ItemReward;
    [SerializeField]
    public int CurrentHealth;
    [SerializeField]
    public int MaxHealth;
    [SerializeField]
    public List<DialogAction> DialogActions;
}