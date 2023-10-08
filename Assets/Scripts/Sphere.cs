using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private Sphere sphere;
    [SerializeField] private string name;
    [SerializeField] private string color;

    private void Awake()
    {
        Instantiate(name,color);
    }

    private void Instantiate(string _name, string _color) // ABSTRACTION
    {
        sphere = this;
        sphere.name = _name;
        sphere.Color = _color;
    }
    protected override void DisplayText(string _name, string _color)
    {
        Debug.Log("This is a " + _name + " and color " + _color);
        Rolling();
    }

    private void Rolling() // ABSTRACTION
    {
        Debug.Log("Might be rolling!");
    }

    void OnMouseDown()
    {
        DisplayText(sphere.name,sphere.Color);
    }
}
