using UnityEngine;
using UnityEngine.UI;

public class UpdateUIStats : MonoBehaviour
{
    public Sprite[] Temprature = new Sprite[31];
    public Sprite[] Gear = new Sprite[11];
    public Sprite[] Sanity = new Sprite[11];
    public Sprite[] Fatigue = new Sprite[11];
    public Sprite[] hunger = new Sprite[11];

    public Image[] UiImages = new Image[5];

    public PlayerStats Stats;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void UpdateUI()
    {
        UiImages[0].sprite = Temprature[Stats.Stats[0]];
        UiImages[1].sprite = Fatigue[Stats.Stats[1]];
        UiImages[2].sprite = Gear[Stats.Stats[2]];
        UiImages[3].sprite = hunger[Stats.Stats[3]];
        UiImages[4].sprite = Sanity[Stats.Stats[4]];
        
    }
}
