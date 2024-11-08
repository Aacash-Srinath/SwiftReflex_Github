using UnityEngine;
using TMPro;

public class VRHandsetCollision : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;  // Assign this in the Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding is the VR Handset (tag it as "VRHandset")
        if (other.gameObject.CompareTag("VRHandset"))
        {
            textDisplay.text = "Collided";
        }
    }
}
