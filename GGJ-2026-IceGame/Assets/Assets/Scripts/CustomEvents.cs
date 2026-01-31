using UnityEngine;

public class CustomEvents : MonoBehaviour
{
    public int[] StatEffected;
    public int[] MagnitutedOfChange= new int[2];

    [TextArea(10, 10)]
    public string MainText;
    public string[] Options = new string[2];

    [TextArea(10,10)]
    public string[] Outcome = new string[2];
}
