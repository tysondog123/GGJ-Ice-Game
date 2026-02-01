using UnityEngine;

public class MapMovement : MonoBehaviour
{
    float Range;
    EventController EventController;
    public GameObject Map;
    Vector3 direction;
    public GameObject PlayerPrevious;
    public GameObject PresetEvent;
    public AudioClip Walk;

    public GameObject[] RangeRefrence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventController = FindAnyObjectByType<EventController>();
        Range = (RangeRefrence[0].transform.position - RangeRefrence[1].transform.position).magnitude+10;
    }

    

    public void PlayerMovement()
    {
        GameObject Player = GameObject.Find("Player");
        Vector3 Angle = (Player.transform.position- transform.position);
        Debug.Log(Angle);
        if (Angle.magnitude < Range && Angle.magnitude >5)
        {
            direction = Player.transform.position - transform.position;
            Map.transform.position = Map.transform.position + Angle;
            EventController.direction = Angle;
            EventController.range = Range;
            EventController.RandomiseEvent(PresetEvent);
            GameObject spawned = Instantiate(PlayerPrevious, transform.position, Quaternion.identity);
            spawned.transform.SetParent(gameObject.transform);
        }
        
    }
    
}
