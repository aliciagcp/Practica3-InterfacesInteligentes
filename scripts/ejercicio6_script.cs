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
        // Move the cube using arrow keys (vertical and horizontal axes)
        float moveVerticalCube = Input.GetAxis("VerticalCube");
        float moveHorizontalCube = Input.GetAxis("HorizontalCube");
        Vector3 movementCube = new Vector3(moveHorizontalCube, moveVerticalCube, 0f) * speed;
        cube.transform.Translate(movementCube);
        
        Vector3 directionToSphere = sphere.transform.position - cube.transform.position;
        Vector3 normalizedDirection = directionToSphere.normalized;
        Vector3 movementCube = normalizedDirection * speed * Time.deltaTime;
        cube.transform.Translate(movementCube);

        // Move the sphere using w-s (vertical movement) and a-d (horizontal movement) keys
        float moveVerticalSphere = Input.GetAxis("VerticalSphere"); 
        float moveHorizontalSphere = Input.GetAxis("HorizontalSphere"); 
        Vector3 movementSphere = new Vector3(moveHorizontalSphere, 0f, moveVerticalSphere) * speed * Time.deltaTime;
        sphere.transform.Translate(movementSphere);
    }
}
