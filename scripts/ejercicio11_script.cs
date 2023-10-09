using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9_3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != null)
        {
            Debug.Log(other.gameObject.tag + " ha entrado en el área del cilindro");
        }
        else
        {
            Debug.Log("Un objeto sin etiqueta ha entrado en el área del cilindro");
        }
    }
}
