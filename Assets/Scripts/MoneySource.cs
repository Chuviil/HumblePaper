using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoneySource : MonoBehaviour
{
    [SerializeField] private Shop shop;
    public int maxRandom = 200;
    public int minRandom = 80;
    public double value;
    public AudioClip moneySound;

    private void Awake()
    {
        shop = GameObject.FindGameObjectWithTag("Shop").GetComponent<Shop>();
    }

    private void Start()
    {
        value = Random.Range(minRandom, maxRandom);
    }

    public void DestroyAndAdd()
    {
        GameObject soundObject = new GameObject("Money Sound");
        AudioSource soundSource = soundObject.AddComponent<AudioSource>();
        soundSource.clip = moneySound;
        soundSource.Play();
        shop.AddMoney(value);
        Destroy(soundObject, soundSource.clip.length);
        Destroy(gameObject);
    }
}
