using UnityEngine;

public class Cube : MonoBehaviour
{
    public float side;
    public Shape shapeProperties = new Shape();
    private Renderer objRenderer;

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        // Access the properties and methods of the Shape class through shapeProperties
        shapeProperties.ChangeColor(Color.red);
        objRenderer.material.color = shapeProperties.color;
    }
}