using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Data : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> Party;
    [SerializeField]
    public Quest CurrentQuest;
    [SerializeField]
    public QuestEvent CurrentQuestEvent;
    [SerializeField]
    public List<Quest> Quests;
    [SerializeField]
    public int PlayerGold;
    [SerializeField]
    public GameObject EventStartNotif;
    [SerializeField]
    public TMPro.TMP_Text EventStartNotifText;
    [SerializeField]
    public int CurrentIntroTextIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentQuest = Quests[0];
        CurrentQuestEvent = CurrentQuest.FinalQuestEvent;
        CurrentQuestEvent.QuestEventState = QuestEventState.Starting;
        EventStartNotifText.text = CurrentQuestEvent.Description;
        EventStartNotif.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdvanceEvent()
    {
        switch(CurrentQuestEvent.QuestEventState)
        {
            case QuestEventState.Starting:
            {
                CurrentQuestEvent.QuestEventState = QuestEventState.Intro;
                EventStartNotifText.text = CurrentQuestEvent.IntroText[CurrentIntroTextIndex];
                CurrentIntroTextIndex++;
                break;
            }
            case QuestEventState.Intro:
            {
                if(CurrentQuestEvent.IntroText.Count > 0)
                {
                    if(CurrentIntroTextIndex < CurrentQuestEvent.IntroText.Count)
                    {
                        EventStartNotifText.text = CurrentQuestEvent.IntroText[CurrentIntroTextIndex];
                        CurrentIntroTextIndex++;
                    }
                    else
                    {
                        EventStartNotifText.text = "";
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
    }
}
