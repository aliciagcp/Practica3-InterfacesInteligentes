using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9_3 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != null)
        {
            Debug.Log("Collision with object tagged: " + collision.gameObject.tag);
        }
        else
        {
            Debug.Log("Collision with untagged object");
        }
    }
}
