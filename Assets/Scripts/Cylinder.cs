using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private Cylinder cylinder;
    [SerializeField] private string name;
    [SerializeField] private string color;
    private void Awake()
    {
        Instantiate(name,color);
    }
    private void Instantiate(string _name, string _color)
    {
        cylinder = this;
        cylinder.name = _name;
        cylinder.Color = _color;
    }
    protected override void DisplayText(string _name, string _color)
    {
        Debug.Log("This is a " + _name + " and color " + _color);
    }

    void OnMouseDown()
    {
        DisplayText(cylinder.name,cylinder.Color);
    }
}
