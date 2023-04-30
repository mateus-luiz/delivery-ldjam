using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaRefill : MonoBehaviour
{
    [Header("Pizza Settings")]
    private PizzaManager pizzaManager;
    public int minPizza;
    public int maxPizza;

    [Header("Timer Settings")]
    private Timer timer;

    void Start()
    {
        pizzaManager = FindFirstObjectByType<PizzaManager>();
        timer = FindFirstObjectByType<Timer>();
    }

    public void RefillPizza()
    {
        int amount = Random.Range(minPizza, maxPizza);

        pizzaManager.SetAmountPizza(amount);
        pizzaManager.SpawnDeliveryPoint();

        timer.PauseTimer(false);
        pizzaManager.DisableAllRefillPoint();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Motorcycle"))
        {
            RefillPizza();
        }
    }
}
