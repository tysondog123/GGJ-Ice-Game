using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public float Range;
    EventController EventController;
    public GameObject Map;
    Vector3 direction;
    public GameObject PlayerPrevious;
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
        Vector3 Angle = (Player.transform.position- transform.position);
        if (Angle.magnitude < Range && Angle.magnitude >5)
        {
            GameObject spawned = Instantiate(PlayerPrevious, transform.position , Quaternion.identity);
            spawned.transform.SetParent(gameObject.transform);
            direction = Player.transform.position - transform.position;
            Map.transform.position = Map.transform.position + Angle;
            EventController.direction = Angle;
            EventController.range = Range;
            EventController.RandomiseEvent();
        }
        
    }
    
}
