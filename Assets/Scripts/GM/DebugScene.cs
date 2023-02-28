using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugScene : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> Party;
    [SerializeField]
    public GameObject SelectedPartyMember;
    [SerializeField]
    public Quest CurrentQuest;
    [SerializeField]
    public EventNode CurrentEventNode;
    [SerializeField]
    public List<EventNode> EventNodes;
    [SerializeField]
    public List<Quest> Quests;
    [SerializeField]
    public int PlayerGold;
    [SerializeField]
    public GameObject EventStartNotif;
    [SerializeField]
    public TMPro.TMP_Text EventStartNotifText;
    [SerializeField]
    public GameObject EventOptions;
    [SerializeField]
    public int TextIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SetActiveQuest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveQuest()
    {
        SelectedPartyMember = Party[0];
        CurrentQuest = Quests[0];
        CurrentEventNode = EventNodes[0];
        EventStartNotifText.text = CurrentEventNode.Text[TextIndex];
        EventStartNotif.SetActive(true);
        EventOptions.SetActive(false);
    }

    public void AdvanceEvent()
    {
        if(TextIndex < CurrentEventNode.Text.Count - 1)
        {
            TextIndex++;
            EventStartNotifText.text = CurrentEventNode.Text[TextIndex];
        }
        else
        {
            foreach(var option in CurrentEventNode.Actions)
            {
                Debug.Log($"{option.Label}");
            }

            var selectedGoCharacter = SelectedPartyMember.GetComponent<GOCharacter>();

            var diceRoll = Random.Range(1,12) + selectedGoCharacter.Character.GetStatValue(CurrentEventNode.Actions[0].StatType);
            Debug.Log(diceRoll);
        }
    }
}
