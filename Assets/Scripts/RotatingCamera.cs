using UnityEngine;

public class RotatingCamera : MonoBehaviour
{
    public Transform target;           // The target point to rotate around.
    public float rotateSpeed = 50f;    // Speed of rotation in degrees per second.

    void Update()
    {
        // Calculate the rotation angle for this frame.
        float angle = rotateSpeed * Time.deltaTime;

        // Rotate around the target's position by the specified angle in the Y axis.
        transform.RotateAround(target.position, Vector3.up, angle);

        // Ensure the camera is always looking at the target.
        transform.LookAt(target);
    }
}
