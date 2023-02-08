using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog : Event
{
    [SerializeField]
    public List<DialogAction> DialogActions;
}
