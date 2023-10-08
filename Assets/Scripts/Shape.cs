using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string name { get; set; } // ENCAPSULATION
    private string color { get; set; } //ENCAPSULATION

    protected string Color //ENCAPSULATION
    {
        get
        {
            return color;
        }
        set
        {
            if (value == "Magenta" || value == "Cyan" || value == "Lime")
            {
                color = value;
            }
            else
            {
                Debug.Log("Invalid color! You can only - Magenta, Cyan or Lime colors");
            }
        }
    }

    protected virtual void DisplayText(string _name,string _color)
    {
        Debug.Log("Some text");
    }
}
