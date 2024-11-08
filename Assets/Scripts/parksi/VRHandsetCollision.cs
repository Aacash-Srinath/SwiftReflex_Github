using UnityEngine;
using TMPro;

public class VRHandsetCollision : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;  // Assign this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object collided with is the 2D image (tag it as "Image" or similar)
        if (other.gameObject.CompareTag("Image"))
        {
            textDisplay.text = "Collided";
        }
    }
}
