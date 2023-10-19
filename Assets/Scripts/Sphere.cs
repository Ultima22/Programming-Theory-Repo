using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float radius;
    public Shape shapeProperties = new Shape();
    private Renderer objRenderer;
   
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        // Access the properties and methods of the Shape class through shapeProperties
        shapeProperties.ChangeColor(Color.green);
        objRenderer.material.color = shapeProperties.Color;
    }

   
}