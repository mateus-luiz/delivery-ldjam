using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaRefill : MonoBehaviour
{
    [SerializeField] private PizzaManager pizzaManager;

    public int minPizza;
    public int maxPizza;

    void Start()
    {
        pizzaManager = FindFirstObjectByType<PizzaManager>();
    }

    public void RefillPizza()
    {
        int amount = Random.Range(minPizza, maxPizza);

        pizzaManager.SetAmountPizza(amount);
        pizzaManager.DisableAllRefillPoint();

        pizzaManager.SpawnDeliveryPoint();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Motorcycle"))
        {
            RefillPizza();
        }
    }
}
