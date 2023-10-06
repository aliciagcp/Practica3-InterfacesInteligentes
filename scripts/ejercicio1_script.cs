using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("Flecha arriba: " + (movementVertical * speed));
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log("Flecha abajo: " + (movementVertical * speed));
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Flecha izquierda: " + (movementHorizontal * speed));
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Flecha derecha: " + (movementHorizontal * speed));
            }
        }
    }
}