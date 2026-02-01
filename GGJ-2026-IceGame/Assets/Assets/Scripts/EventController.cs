using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventController : MonoBehaviour
{
    public GameObject[] Events;
    public TextMeshProUGUI MainText;
    public TextMeshProUGUI[] options;
    public GameObject ChoiceUI;

    public GameObject ResultUI;
    public TextMeshProUGUI Results;

    PlayerStats playerStats;
    GameObject chosenEvent;


    public GameObject Destination;
    public GameObject MapButtons;
    public Vector3 direction;
    public GameObject Map;
    public float range;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandomiseEvent(GameObject PresetEvent)
    {
        if (PresetEvent == null)
        {
            chosenEvent = Events[Random.Range(0, Events.Length)];
            LoadOption(chosenEvent);
        }
        else
        {
            LoadOption(PresetEvent);
            PresetEvent = null;
        }
    }


    public void LoadOption(GameObject Event)
    {
        Map.gameObject.SetActive(false);
        ChoiceUI.SetActive(true);
        MainText.text = Event.GetComponent<CustomEvents>().MainText;
        if (Event.GetComponent<CustomEvents>().Options.Length <= 1) 
        {
            options[1].gameObject.SetActive(false);
        }
        else
        {
            options[1].gameObject.SetActive(true);
            options[1].text = Event.GetComponent<CustomEvents>().Options[1];
            
        }
        options[0].text = Event.GetComponent<CustomEvents>().Options[0];
    }
    public void Effect(int Selected)
    {
        if (options[0].text == "Retreat" || options[1].text == "Retreat")
        {
            MoveBack();
        }
        CustomEvents custom = chosenEvent.GetComponent<CustomEvents>();
        if(custom != null && playerStats.Stats[custom.StatMesured[Selected]]< custom.StatValueToPass[Selected])
        {
            playerStats.EffectStat(custom.StatChangeOnFail[Selected], custom.NumberChangedOnFail[Selected]);
            if (custom.MultipleNegatives)
            {
                playerStats.EffectStat(custom.SecondaryStatChanged,custom.SecondaryValueChange);
            }
            ChoiceUI.SetActive(false);
            ResultUI.SetActive(true);
            Results.text = custom.FailOutcome[Selected];
        }else
        {
            playerStats.EffectStat(custom.StatChangeOnPass[Selected], custom.NumberChangedOnPass[Selected]);
            ChoiceUI.SetActive(false);
            ResultUI.SetActive(true);
            Results.text = custom.PassOutcome[Selected];
        }
        
    }
    public void CloseMenu()
    {
        ResultUI.SetActive(false);
        Map.SetActive(true);
    }
    public void MoveBack()
    {
       //Map.transform.position = Map.transform.position - direction;
    }
    public void WinCon()
    {
        if (direction.magnitude < range && direction.magnitude > 5)
        {
            SceneManager.LoadScene("Win");
        }
    }

}
