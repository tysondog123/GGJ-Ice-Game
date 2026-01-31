using UnityEngine;

public class CustomEvents : MonoBehaviour
{
    [Header("1-Temprature, 2-Fatigue, 3-Gear status, 4-Hunger, 5-Sanity")]
    public int[] Option1EffectedStats;
    public int[] Option2EffectedStats;
    public int[] MagnitutedOfChangeOption1;
    public int[] MagnitutedOfChangeOption2;
    public int[] effectors = new int[2];
    public int[] SecondaryStatEffected;

    [TextArea(10, 10)]
    public string MainText;
    public string[] Options = new string[2];

    [TextArea(10,10)]
    public string[] Outcome = new string[2];
}
