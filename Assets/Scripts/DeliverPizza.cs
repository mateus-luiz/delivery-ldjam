using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPizza : MonoBehaviour
{
    private PizzaManager pizzaManager;

    void Start() 
    {
        pizzaManager = FindFirstObjectByType<PizzaManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Motorcycle"))
        {
            Delivery();
        }
    }

    public void Delivery()
    {
        int amountPizza = pizzaManager.GetAmountPizza();
        if(amountPizza > 0)
        {
            amountPizza--;
            pizzaManager.SetAmountPizza(amountPizza);
            pizzaManager.SpawnDeliveryPoint();
        }
        else
        {
            pizzaManager.EnableAllRefillPoint();
        }
        
        Destroy(this.gameObject);
    }
}
