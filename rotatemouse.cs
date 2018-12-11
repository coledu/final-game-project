using UnityEngine;
using System.Collections;

public class rotatemouse : MonoBehaviour

{


    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    void Update()
   
    {
        Cursor.visible = false;//fix issue with cusor begin off by making it disappear. This need to be fix by the final version
        float H = horizontalSpeed * Time.deltaTime * Input.GetAxis("Mouse X") * 10;
        //float V = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, H, 0);
    }
}
