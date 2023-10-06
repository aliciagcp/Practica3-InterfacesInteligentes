using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1f, 0f, 0f);
    public float speed = 2f;

    void Update()
    {
        Vector3 displacement = moveDirection * speed * Time.deltaTime;
        transform.Translate(displacement);
    }
}
