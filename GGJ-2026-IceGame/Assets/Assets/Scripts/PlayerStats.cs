using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class PlayerStats : MonoBehaviour
{
    public Sprite[] Temprature;
    public Sprite[] Gear;
    public Sprite[] Sanity;
    public Sprite[] Fatigue;
    public Sprite[] hunger;

    

    [Header("1-Temprature, 2-Fatigue, 3-Gear status, 4-Hunger, 5-Sanity")]
    public int[] Stats;
    public int[] StatMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float TimeLeft=1800;
    public TextMeshProUGUI Time;
    public GameObject menu;
    public Transform[] Destination;
    public GameObject[] UiImages;

    private void Start()
    {
        StartCoroutine(TimeTillFreeze());
    }
    public void EffectStat(int WhichStat, int Change)
    {
        if(Stats[WhichStat] + Change <= StatMax[WhichStat])
        {
            Stats[WhichStat] = Stats[WhichStat]+ Change;
            UpdateUI();
        }
    }
   IEnumerator TimeTillFreeze()
   {
        yield return new WaitForSeconds(1f);
        TimeLeft--;
        if (Time.IsActive())
        {
            updateUITime();
        }
        

            StartCoroutine(TimeTillFreeze());
   }
    public void updateUITime()
    {
        if (TimeLeft - (Mathf.FloorToInt(TimeLeft / 60) * 60) > 9)
        {
            Time.text = Mathf.FloorToInt(TimeLeft / 60).ToString() + ":" + (TimeLeft - (Mathf.FloorToInt(TimeLeft / 60) * 60));
        }
        else
        {
            Time.text = Mathf.FloorToInt(TimeLeft / 60).ToString() + ":0" + (TimeLeft - (Mathf.FloorToInt(TimeLeft / 60) * 60));
        }
    }
    public void OpenMenu()
    {
        if (menu.activeSelf) 
        {
            menu.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
            updateUITime();
        }
    }
    public void UpdateUI()
    {
        Debug.Log(Temprature[Stats[1]]);
        UiImages[0].GetComponent<Image>().sprite = Temprature[Stats[0]];
        UiImages[1].GetComponent<Image>().sprite = Fatigue[Stats[1]];
        UiImages[2].GetComponent<Image>().sprite = Gear[Stats[2]];
        UiImages[3].GetComponent<Image>().sprite = hunger[Stats[3]];
        UiImages[4].GetComponent<Image>().sprite = Sanity[Stats[4]];
    }
}


    