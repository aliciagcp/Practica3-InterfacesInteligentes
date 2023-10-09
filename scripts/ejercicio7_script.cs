using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUsingKeys : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public float speed = 5f;

    void Update()
    {
        float moveVerticalCube = Input.GetAxis("VerticalCube");
        float moveHorizontalCube = Input.GetAxis("HorizontalCube");
        Vector3 movementCube = new Vector3(moveHorizontalCube, moveVerticalCube, 0f) * speed;
        cube.transform.Translate(movementCube);
        
        Vector3 directionToSphere = sphere.transform.position - cube.transform.position;
        cube.transform.LookAt(sphere.transform, Vector3.up);
        Vector3 movement = cube.transform.forward * speed * Time.deltaTime;
        cube.transform.Translate(movement, Space.World);

        // Mueve la esfera usando w-s (movimiento vertical) y a-d (movimiento horizontal) keys
        float moveVerticalSphere = Input.GetAxis("VerticalSphere"); 
        float moveHorizontalSphere = Input.GetAxis("HorizontalSphere"); 
        Vector3 movementSphere = new Vector3(moveHorizontalSphere, 0f, moveVerticalSphere) * speed * Time.deltaTime;
        sphere.transform.Translate(movementSphere);
    }
}
