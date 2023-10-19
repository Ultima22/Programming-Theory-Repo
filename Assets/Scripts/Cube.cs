using UnityEngine;

public class Cube : MonoBehaviour
{
    public float side;
    public Shape shapeProperties = new Shape();
    private Renderer objRenderer;
    public float rotateSpeed = 30f;
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        // Access the properties and methods of the Shape class through shapeProperties
        shapeProperties.ChangeColor(Color.red);
        objRenderer.material.color = shapeProperties.Color;
    }

    private void Update()
    {
        RotatingCube(); 
    }

    public void RotatingCube()
    {
        transform.Rotate(1.5f * rotateSpeed * Time.deltaTime, rotateSpeed * Time.deltaTime, 2 * rotateSpeed * Time.deltaTime);
    }
}