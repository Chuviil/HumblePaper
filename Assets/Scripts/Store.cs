using System;
using UnityEngine;
using TMPro;

public class Store : MonoBehaviour
{
    public Shop generalShop;
    public GameObject soldItemPrefab;
    public string soldItemName;
    public double price;
    public TMP_Text priceText;
    public TMP_Text nameText;

    private void Awake()
    {
        generalShop = GameObject.FindGameObjectWithTag("Shop").GetComponent<Shop>();
    }

    private void Start()
    {
        priceText.text = "$" + price;
        nameText.text = soldItemName;
    }

    public void BuyItem()
    {
        if (generalShop.ReduceMoney(price))
        {
            Instantiate(soldItemPrefab, transform.position + Vector3.right, Quaternion.identity);
        }
    }
}
