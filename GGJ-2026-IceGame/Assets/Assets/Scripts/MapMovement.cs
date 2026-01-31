using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapMovement : MonoBehaviour
{
    public Button[] Neibours;
    public float Range;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void EnableNeibours()
    {
        GameObject Player = GameObject.Find("Player");
        float Distance = (transform.position - Player.transform.position).magnitude;
        if (Distance < Range)
        {
            Player.transform.position = transform.position;
        }
        
    }
}
