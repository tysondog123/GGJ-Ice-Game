using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnStartButton() 
    {
        SceneManager.LoadScene("");
    }

    public void OnCreditsButton() 
    {
        SceneManager.LoadScene("");
    }

    public void OnExitButton()
    {
        SceneManager.LoadScene("");
    }
}
