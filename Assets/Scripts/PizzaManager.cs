using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int pizzaAmount = 0;

    [SerializeField] private GameObject[] pizzaRefillPoint;

    [SerializeField] private GameObject pizzaDeliveryObject;
    [SerializeField] private Transform[] pizzaDeliverSpawnPoints;

    void Start()
    {
        player = FindObjectOfType<MotorcycleController>().gameObject;
    }

    void Update()
    {
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
}
