using System;
using UnityEngine;

public class ReceptorPlace : MonoBehaviour
{
    public string requestedObject;

    private void OnTriggerEnter(Collider other)
    {
        var deliveryObject = other.GetComponent<DeliveryObject>();
        if (deliveryObject == null) return;
        if (deliveryObject.name == requestedObject)
        {
            Debug.Log("Correct delivery object placed!");
            // Perform desired action when correct object is placed
        }
        else
        {
            Debug.Log("Incorrect delivery object placed!");
            // Perform desired action when incorrect object is placed
        }
    }
}
