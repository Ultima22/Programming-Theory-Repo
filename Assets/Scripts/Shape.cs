using UnityEngine;

public class Shape
{
    public Vector3 position;
    private Color color;

    public Color Color //ENCAPSULATION
    {
        get { return color; }
        set { color = value; } // You can also implement validation here if needed.
    }

    public virtual void Move(Vector3 direction)
    {
        position += direction;
    }

    public void ChangeColor(Color newColor)
    {
        color = newColor;
    }
}