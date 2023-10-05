using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFireKey : MonoBehaviour
{
   void Update()
    {
        // Comprobar si la tecla H está siendo presionada para disparar
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Disparo!");
        }
    }

}
