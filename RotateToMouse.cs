using UnityEngine;
using System.Collections;

public class RotateToMouse : MonoBehaviour

{


    public float horizontalSpeed = 50.0F;
    public float verticalSpeed = 2.0F;
    void Update()
    {
        float h = horizontalSpeed * 90 * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);
    }
}
