using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandomiseEvent()
    {
        chosenEvent=Events[Random.Range(0,Events.Length)];
        LoadOption(chosenEvent);
    }


    public void LoadOption(GameObject Event)
    {
        ChoiceUI.SetActive(true);
        MainText.text = Event.GetComponent<CustomEvents>().MainText;
        options[0].text = Event.GetComponent<CustomEvents>().Options[0];
        options[1].text = Event.GetComponent<CustomEvents>().Options[1];
    }
    public void Effect(int Option)
    {
        CustomEvents custom = chosenEvent.GetComponent<CustomEvents>();
        playerStats.EffectStat(custom.StatEffected[Option], custom.MagnitutedOfChange[Option]);
        ChoiceUI.SetActive(false);
        ResultUI.SetActive(true);
        Results.text = custom.Outcome[Option];
    }
    public void CloseMenu()
    {
        ResultUI.SetActive(false);
    }

}
