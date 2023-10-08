using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {
        float horizontalInput = Input.GetAxis("HorizontalCube");
        float rotationY = horizontalInput * Time.deltaTime * 100f;
        transform.Rotate(0f, rotationY, 0f);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
