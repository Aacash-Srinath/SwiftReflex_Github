using UnityEngine;
using TMPro;

public class SaberCollision : MonoBehaviour
{
    public TextMeshProUGUI collisionText; // Reference to the TextMeshPro text field

    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider is the boundary
        if (other.CompareTag("Image"))
        {
            collisionText.text = "TOUCHED";
        }
    }
}
