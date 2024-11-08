using UnityEngine;
using TMPro;

public class VRHandsetCollision : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;  // Assign this in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object colliding is the VR Handset (tag it as "VRHandset")
        if (collision.gameObject.CompareTag("VRHandset"))
        {
            textDisplay.text = "Collided";
        }
    }
}
