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
    public QuestEvent CurrentQuestEvent;
    [SerializeField]
    public List<QuestEvent> QuestEvents;
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
    public int TextIndex;
    
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
        CurrentQuestEvent = QuestEvents[0];
        EventStartNotifText.text = CurrentQuestEvent.Description;
        EventStartNotif.SetActive(true);
        EventOptions.SetActive(false);
    }

    public void AdvanceEvent()
    {
        /*
        switch(CurrentQuestEvent.QuestEventState)
        {
            case QuestEventState.Starting:
            {
                CurrentQuestEvent.QuestEventState = QuestEventState.Intro;
                EventStartNotifText.text = CurrentQuestEvent.IntroText[TextIndex];
                TextIndex++;
                break;
            }
            case QuestEventState.Intro:
            {
                if(CurrentQuestEvent.IntroText.Count > 0)
                {
                    if(TextIndex < CurrentQuestEvent.IntroText.Count)
                    {
                        EventStartNotifText.text = CurrentQuestEvent.IntroText[TextIndex];
                        TextIndex++;
                    }
                    else
                    {
                        EventStartNotifText.text = "";
                        EventStartNotif.SetActive(false);
                        EventOptions.SetActive(true);
                        CurrentQuestEvent.QuestEventState = QuestEventState.During;
                    }
                }

                break;
            }
            case QuestEventState.During:
            {

                break;
            }
            case QuestEventState.Outro:
            {
                break;
            }
            default:
            {
                break;
            }
        }
        */
    }

    public void TrySolution(string StatType)
    {
        var selectedGoCharacter = SelectedPartyMember.GetComponent<GOCharacter>();

        switch(StatType.ToUpper())
        {
            case "BEATDOWN":
            {
                var statModifier = selectedGoCharacter.Character.Stats.Strength - CurrentQuestEvent.Stats.Strength;
                Debug.Log(statModifier);

                break;
            }
            default:
            {
                break;
            }
        }
    }
}
