using UnityEngine;

public class Capsule : MonoBehaviour //INHERITANCE
{
    public float height;
    public float radius;
    private Renderer objRenderer;
    public Shape shapeProperties = new Shape();
    public float rotateSpeed = 30f;

    void Start() //POLYMORPHISM
    {
        objRenderer = GetComponent<Renderer>();
        // Access the properties and methods of the Shape class through shapeProperties
        shapeProperties.ChangeColor(Color.blue);
        objRenderer.material.color = shapeProperties.Color;

    }

    private void Update()
    {
        Rotating(); //ABSTRACTION
    }

    public void Rotating()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }

}