using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogAction
{
    [SerializeField]
    public StatType StatType;
    [SerializeField]
    public int StatTarget;
    [SerializeField]
    public string Text;
}
