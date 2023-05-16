using UnityEngine;

public class Interactables : MonoBehaviour
{
    // Public variables
    public float pickupRange = 1.2f; // Maximum distance for object pickup
    public Transform holdPosition; // Position where object is held
    public LayerMask pickupLayer; // Layer that contains pickuppable objects
    public KeyCode interactKey = KeyCode.E;

    // Private variables
    private GameObject heldObject = null; // Object currently held by player

    void Update()
    {
        // Check if "Interact" button is pressed
        if (Input.GetKeyDown(interactKey))
        {
            // If player is not holding an object, attempt to pick one up
            if (heldObject == null)
            {
                // Check for nearby objects in pickup layer
                Collider[] hitColliders = Physics.OverlapSphere(transform.position, pickupRange, pickupLayer);

                // If an object is found, pick it up
                if (hitColliders.Length > 0)
                {
                    heldObject = hitColliders[0].gameObject; // Pick up the first object found
                    heldObject.transform.position = holdPosition.position; // Move object to hold position
                    heldObject.transform.parent = holdPosition; // Set object's parent to hold position
                    heldObject.GetComponent<Rigidbody>().isKinematic = true; // Disable physics on object
                }
            }
            // If player is holding an object, set it down
            else
            {
                heldObject.transform.parent = null; // Remove object's parent
                heldObject.GetComponent<Rigidbody>().isKinematic = false; // Enable physics on object
                heldObject = null; // Clear heldObject variable
            }
        }
    }
}

