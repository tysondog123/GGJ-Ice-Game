using UnityEngine;
using UnityEngine.UI;

public class MapMovement : MonoBehaviour
{
    public Button[] Neibours;
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
        foreach (Button button in Neibours) 
        { 
          button.enabled = true;
        }
        GetComponent<Button>().enabled = false;
    }
}
