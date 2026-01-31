using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class PlayerStats : MonoBehaviour
{
    //public int Temprature;
    //public int Gear;
    //public int Sanity;
    //public int Fatigue;
    [Header("1-Temprature, 2-Fatigue, 3-Gear status, 4-Hunger, 5-Sanity")]
    public int[] Stats;
    public int[] StatMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float TimeLeft=1800;
    public TextMeshProUGUI Time;
    public GameObject menu;
    public Transform[] Destination;

    private void Start()
    {
        StartCoroutine(TimeTillFreeze());
    }
    public void EffectStat(int WhichStat, int Change)
    {
        if(Stats[WhichStat] + Change <= StatMax[WhichStat])
        {
            
            Stats[WhichStat] = Stats[WhichStat]+ Change;
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
    public void WinCon()
    {
       SceneManager.LoadScene("Win");
    }
}


    