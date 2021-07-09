using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicText : MonoBehaviour
{
    private Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
    }
    public void TextUpdate(int number)
    {
        text.text = number.ToString();
    }
    public void TextUpdateName(string name)
    {
        if(name.Length < 10)
        {
            text.text = name;
        }
        
    }
}
