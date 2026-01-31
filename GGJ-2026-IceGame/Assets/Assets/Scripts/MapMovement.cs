using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapMovement : MonoBehaviour
{
    public float Range;
    EventController EventController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventController = FindAnyObjectByType<EventController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void EnableNeibours()
    {
        GameObject Player = GameObject.Find("Player");
        float Distance = (transform.position - Player.transform.position).magnitude;
        Debug.Log(Distance);
        if (Distance < Range && Distance >5)
        {
            Player.transform.position = transform.position;
            EventController.RandomiseEvent();
        }
        
    }
}
