using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(verticalInput * speed, 0, 0);
            if (Input.GetKey(KeyCode.UpArrow)) 
            {
                Debug.Log("Nombre de la flecha: up, Velocidad: " + movement);
            }
            if (Input.GetKey(KeyCode.DownArrow)) 
            {
                Debug.Log("Nombre de la flecha: down, Velocidad: " + movement);
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(horizontalInput * speed, 0, 0);
            if (Input.GetKey(KeyCode.LeftArrow)) 
            {
                Debug.Log("Nombre de la flecha: left, Velocidad: " + movement);
            }
            if (Input.GetKey(KeyCode.RightArrow)) 
            {
                Debug.Log("Nombre de la flecha: right, Velocidad: " + movement);
            }
        }
    }
}