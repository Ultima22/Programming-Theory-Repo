using UnityEngine;

public class Shape
{
    public Vector3 position;
    public Color color;

    public virtual void Move(Vector3 direction)
    {
        position += direction;
    }

    public void ChangeColor(Color newColor)
    {
        color = newColor;
    }
}