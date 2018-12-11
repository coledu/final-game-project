using UnityEngine;
using System.Collections;

public class play_move : MonoBehaviour
{

    public float speed;

    void Update()
        //move the player with aswd key mapping
    {
        if (Input.GetKey(KeyCode.D))
        {transform.Translate(Vector3.right * speed);}
        if (Input.GetKey(KeyCode.A))
        {transform.Translate(-Vector3.right * speed);}
        if (Input.GetKey(KeyCode.W))
        {transform.Translate(Vector3.forward * speed);}
        if (Input.GetKey(KeyCode.S))
        {transform.Translate(-Vector3.forward * speed);}
    }
}
