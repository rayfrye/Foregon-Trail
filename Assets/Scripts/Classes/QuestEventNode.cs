using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEventNode
{
    [SerializeField]
    public List<string> Text;
    [SerializeField]
    public List<QuestEventNodeAction> Actions;
}
