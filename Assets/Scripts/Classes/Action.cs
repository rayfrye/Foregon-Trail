using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Action
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public List<ActionResult> ActionResults;
}

