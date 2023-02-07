using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Profile
{
    [SerializeField]
    public string FirstName;
    [SerializeField]
    public string LastName;
    [SerializeField]
    public string Description;
    public string FullName => $"{FirstName} {LastName}";
}