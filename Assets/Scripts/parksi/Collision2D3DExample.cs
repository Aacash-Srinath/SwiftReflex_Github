using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2D3DExample : MonoBehaviour
{
    
    // For 2D collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "3DObject")
        {
            Debug.Log("2D object collided with: " + collision.gameObject.name);
        }
    }

    // For 3D collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "3DObject")
        {
            Debug.Log("2D object collided with 3D object: " + collision.gameObject.name);
        }
    }
}
