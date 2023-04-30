using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPizza : MonoBehaviour
{
    private PizzaManager pizzaManager;

    [Header("Timer Settings")]
    [SerializeField] private Timer timer;

    [Header("Score Settings")]
    [SerializeField] private ScoreManager scoreManager;

    void Start() 
    {
        pizzaManager = FindFirstObjectByType<PizzaManager>();
        timer = FindFirstObjectByType<Timer>();
        scoreManager = FindFirstObjectByType<ScoreManager>();
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
        
        if(amountPizza <= 0)
        {   
            timer.PauseTimer(true);
            pizzaManager.EnableAllRefillPoint();
        }
        
        scoreManager.IncreaseScore();
        Destroy(this.gameObject);
    }
}
