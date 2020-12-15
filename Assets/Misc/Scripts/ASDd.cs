using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASDd : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right;
        }
    }
}