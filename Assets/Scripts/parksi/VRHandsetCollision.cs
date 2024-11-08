using UnityEngine;
using TMPro;

public class ObjectCollision : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;  // Assign in Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object has the tag "MovingObject"
        if (other.CompareTag("3DObject"))
        {
            textDisplay.text = "Collision Detected!";
        }
    }
}