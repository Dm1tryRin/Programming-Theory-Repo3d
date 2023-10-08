using UnityEngine;

public class Cube : Shape //INHERITANCE
{
    private Cube cube;
    [SerializeField] private string name;
    [SerializeField] private string color;
    private void Awake()
    {
        Instantiate(name,color);
    }
    private void Instantiate(string _name, string _color)
    {
        cube = this;
        cube.name = _name; 
        cube.Color = _color;
    }
    protected override void DisplayText(string _name, string _color) //POLYMORPHISM
    {
        Debug.Log("This is a " + _name + " and color " + _color);
    }

    void OnMouseDown()
    {
        DisplayText(cube.name,cube.Color);
    }
}
