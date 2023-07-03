using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class ReceptorPlace : MonoBehaviour
{
    public float intervaloDeRevision = 120f;
    public List<String> objetosPosibles = new List<String>() { "Guitar", "Popcorn", "Plant" };
    public GameObject explosionPrefab;

    [SerializeField] private string _objetoPedido;

    private void Start()
    {
        InvokeRepeating("RevisarSolicitado", 0f, intervaloDeRevision);
    }

    public void RevisarSolicitado()
    {
        if (string.IsNullOrEmpty(_objetoPedido))
        {
            int indice = Random.Range(0, objetosPosibles.Count);
            _objetoPedido = objetosPosibles[indice];
            Debug.Log("Se asigno una entrega: " + _objetoPedido);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var deliveryObject = other.GetComponent<DeliveryObject>();
        if (deliveryObject == null) return;
        if (deliveryObject.name == _objetoPedido)
        {
            _objetoPedido = "";
            Debug.Log("Entrega correcta de " + _objetoPedido);
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Item entregado no es correcto!");
            GameObject explosionP = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(explosionP, explosionPrefab.GetComponent<ParticleSystem>().main.duration);
        }
    }
}