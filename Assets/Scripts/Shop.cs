using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public double money = 250;
    public List<TMP_Text> moneyDisplays;

    private void Start()
    {
        UpdateMoneyDisplays();
    }

    public void AddMoney(double amount)
    {
        money += amount;
        UpdateMoneyDisplays();
    }

    public void UpdateMoneyDisplays()
    {
        foreach (TMP_Text display in moneyDisplays)
        {
            display.text = "$" + money;
        }
    }
}