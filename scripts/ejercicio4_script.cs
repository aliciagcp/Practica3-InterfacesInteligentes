using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUsingKeys : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public float speed = 0.25f;

    void Update()
    {
        // Move the cube using arrow keys (vertical and horizontal axes)
        float moveVerticalCube = Input.GetAxis("VerticalCube");
        float moveHorizontalCube = Input.GetAxis("HorizontalCube");
        Vector3 movementCube = new Vector3(moveHorizontalCube, 0f, moveVerticalCube) * speed;
        cube.transform.Translate(movementCube);

        // Move the sphere using w-s (vertical movement) and a-d (horizontal movement) keys
        float moveVerticalSphere = Input.GetAxis("VerticalSphere"); 
        float moveHorizontalSphere = Input.GetAxis("HorizontalSphere"); 
        Vector3 movementSphere = new Vector3(moveHorizontalSphere, 0f, moveVerticalSphere) * speed;
        sphere.transform.Translate(movementSphere);
    }
}
