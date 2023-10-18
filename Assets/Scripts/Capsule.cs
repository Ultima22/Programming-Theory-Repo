using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float height;
    public float radius;
    private Renderer objRenderer;
    public Shape shapeProperties = new Shape();

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        // Access the properties and methods of the Shape class through shapeProperties
        shapeProperties.ChangeColor(Color.blue);
        objRenderer.material.color = shapeProperties.color;
    }
}