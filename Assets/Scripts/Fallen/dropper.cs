using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class CylinderDropper : MonoBehaviour
{
    public float minDelay = 1.0f;
    public float maxDelay = 10.0f;
    private Rigidbody rb;
    private Collider objectCollider;
    private Renderer cylinderRenderer;
    private XRGrabInteractable grabInteractable;
    public Color newColor = Color.green;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        objectCollider = GetComponent<Collider>();
        objectCollider.enabled = false;
        StartCoroutine(DropCylinder());
    }

    private IEnumerator DropCylinder()
    {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        rb.useGravity = true;
        objectCollider.enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "GameController")
        {
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = newColor;
                ScoreManager.AddScore(10);
            }
        }
    }
}
