using System.Drawing;

public abstract class Shape {
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void SetColor(string newColor) 
    {
        _color = newColor;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
}