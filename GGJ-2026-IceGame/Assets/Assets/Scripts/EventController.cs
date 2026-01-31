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
    public GameObject MapButtons;
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
        MapButtons.gameObject.SetActive(false);
        ChoiceUI.SetActive(true);
        MainText.text = Event.GetComponent<CustomEvents>().MainText;
        options[0].text = Event.GetComponent<CustomEvents>().Options[0];
        options[1].text = Event.GetComponent<CustomEvents>().Options[1];
    }
    public void Effect(int Selected)
    {
        CustomEvents custom = chosenEvent.GetComponent<CustomEvents>();
        if(custom != null && custom.effectors[Selected]) {
        playerStats.EffectStat(custom.Option1EffectedStats[Selected], custom.MagnitutedOfChange[Selected]);
        Debug.Log(custom.MagnitutedOfChange[Selected]);
        ChoiceUI.SetActive(false);
        ResultUI.SetActive(true);
        Results.text = custom.Outcome[Selected];
    }
    public void CloseMenu()
    {
        ResultUI.SetActive(false);
        MapButtons.SetActive(true);
    }

}
