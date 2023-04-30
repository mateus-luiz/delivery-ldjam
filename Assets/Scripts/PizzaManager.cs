using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PizzaManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    
    [Header("Pizza Settings")]
    [SerializeField] private int pizzaAmount = 0;

    [Header("Spawners")]
    [SerializeField] private GameObject[] pizzaRefillPoint;
    [SerializeField] private GameObject pizzaDeliveryObject;
    [SerializeField] private Transform[] pizzaDeliverSpawnPoints;

    [Header("Pizza UI")]
    [SerializeField] private TextMeshProUGUI pizzaAmountText;

    void Start()
    {
        player = FindObjectOfType<MotorcycleController>().gameObject;
    }

    void Update()
    {
        pizzaAmountText.text = pizzaAmount.ToString("00");

        if(pizzaAmount == 0)
        {
            EnableAllRefillPoint();
        }
    }

    public void SetAmountPizza(int amount)
    {
        pizzaAmount = amount;    
    }

    public int GetAmountPizza()
    {
        return pizzaAmount;
    }

    public void DisableAllRefillPoint() {
        foreach(GameObject point in pizzaRefillPoint)
        {
            point.SetActive(false);
        }
    }

    public void EnableAllRefillPoint()
    {
        foreach(GameObject point in pizzaRefillPoint)
        {
            point.SetActive(true);
        }
    }

    public void SpawnDeliveryPoint()
    {
        int pos = Random.Range(0, pizzaDeliverSpawnPoints.Length);
        Instantiate(pizzaDeliveryObject, pizzaDeliverSpawnPoints[pos].position, Quaternion.identity);
    }
    
    public void ResetDelivery()
    {
        DeliverPizza[] deliverPoints = FindObjectsOfType<DeliverPizza>();
        foreach(DeliverPizza deliveryPoint in deliverPoints)
        {
            Destroy(deliveryPoint.gameObject);
        }

        EnableAllRefillPoint();
    }
}
