using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class CylinderDropper : MonoBehaviour
{
    public float minDelay = 1.0f;
    public float maxDelay = 10.0f;
    private Rigidbody rb;
    private Renderer cylinderRenderer;
    private XRGrabInteractable grabInteractable;
    public Color newColor = Color.red;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //grabInteractable = GetComponent<XRGrabInteractable>();

        // Add listener for select event to change color
        //grabInteractable.selectEntered.AddListener(ChangeColor);

        StartCoroutine(DropCylinder());
    }

    private IEnumerator DropCylinder()
    {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        rb.useGravity = true;
    }

    private void ChangeColor(SelectEnterEventArgs args)
    {
        cylinderRenderer.material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "GameController")
        {
            // Get the Renderer component of the object and change the material color
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = newColor;
            }
        }
        //Renderer renderer = GetComponent<Renderer>();
        //if (renderer != null)
        //{
        //    renderer.material.color = newColor;
        //}
    }
}
