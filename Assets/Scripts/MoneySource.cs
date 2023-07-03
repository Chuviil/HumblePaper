using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoneySource : MonoBehaviour
{
    [SerializeField] private Shop shop;
    public double value;

    private void Awake()
    {
        shop = GameObject.FindGameObjectWithTag("Shop").GetComponent<Shop>();
    }

    private void Start()
    {
        value = Random.Range(80, 200);
    }

    public void DestroyAndAdd()
    {
        shop.AddMoney(value);
        Destroy(gameObject);
    }
}
