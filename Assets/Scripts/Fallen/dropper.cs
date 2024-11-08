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

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cylinderRenderer = GetComponent<Renderer>();
        grabInteractable = GetComponent<XRGrabInteractable>();

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
}
