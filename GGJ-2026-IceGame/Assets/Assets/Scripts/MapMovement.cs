using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapMovement : MonoBehaviour
{
    public float Range;
    EventController EventController;
    public GameObject Map;
    Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventController = FindAnyObjectByType<EventController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void PlayerMovement()
    {
        GameObject Player = GameObject.Find("Player");
        float Distance = (Player.transform.position- transform.position).magnitude;
        if (Distance < Range && Distance >5)
        {
            direction = Player.transform.position - transform.position;
            Map.transform.position = Map.transform.position + direction;
            EventController.direction = direction;
            EventController.range = Range;
            EventController.RandomiseEvent();
        }
        
    }
    
}
