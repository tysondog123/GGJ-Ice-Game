using UnityEngine;

public class CustomEvents : MonoBehaviour
{
    [Header("0-Temprature, 1-Fatigue, 2-Gear status, 3-Hunger, 4-Sanity")]
    public int[] StatChangeOnFail;
    public int[] StatChangeOnPass;
    public int[] NumberChangedOnFail;
    public int[] NumberChangedOnPass;
    public int[] StatValueToPass = new int[2];
    public int[] StatMesured = new int[2];
    public bool MultipleNegatives;
    public int SecondaryStatChanged;
    public int SecondaryValueChange;

    [TextArea(10, 10)]
    public string MainText;
    public string[] Options = new string[2];

    [TextArea(10,10)]
    public string[] FailOutcome = new string[2];
    [TextArea(10, 10)]
    public string[] PassOutcome = new string[2];
}
