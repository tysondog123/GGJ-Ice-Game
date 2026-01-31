using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //public int Temprature;
    //public int Gear;
    //public int Sanity;
    //public int Fatigue;
    public int[] Stats;
    public int StatMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void EffectStat(int WhichStat, int Change)
    {
        if((Stats[WhichStat] += Change) <= StatMax)
        {
            Stats[WhichStat] += Change;
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
