using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayableCharacter : Character
{
    public PlayableCharacter()
    {

    }

    [SerializeField]
    public bool IsUnlocked;
    [SerializeField]
    public int CostToHire;
    
}

