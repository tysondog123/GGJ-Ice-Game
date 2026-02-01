using System.Collections;
using TMPro;
using UnityEngine;

public class RevealText : MonoBehaviour
{
    bool TextRevealed=false;
    public TextMeshProUGUI TextBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        TextBox = GetComponent<TextMeshProUGUI>();
        StartCoroutine(RevalLetter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator RevalLetter()
    {
        int Textlength = 0;
        TextBox.maxVisibleCharacters = 0;
        while (Textlength < TextBox.text.Length)
        {
            Textlength++;
            TextBox.maxVisibleCharacters=Textlength;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
